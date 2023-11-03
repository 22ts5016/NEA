using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Text.RegularExpressions;

namespace Do_IT
{
    public partial class StockWriteOff : Form
    {
        public StockWriteOff()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mainmenu.Show();
            this.Hide();
        }

        private void StockWriteOff_Load(object sender, EventArgs e)
        {
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand("SELECT Reason FROM StockWriteOffReasons", Forms.conn);
            SQLiteDataReader reader = sql.ExecuteReader();

            while(reader.Read())
            {
                WriteOffReasonComboBox.Items.Add((string)reader["Reason"]);
            }
            reader.Close();
            Forms.conn.Close();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string barcode = BarcodeTextBox.Text;
            if (WriteOffReasonComboBox.SelectedIndex != -1)
            {
                if (Regex.IsMatch(BarcodeTextBox.Text, RegExFormats.anynumber))
                {
                    if (ProductQuery.CheckValidBarcode(barcode))
                    {
                        string barcodeandindex = barcode + "_" + WriteOffReasonComboBox.SelectedIndex + "_";
                        if (!CheckDuplicatesInList(barcodeandindex))
                        {
                            TableLayoutPanel table = new TableLayoutPanel();

                            table.Name = barcodeandindex + "Table";
                            table.AutoSize = true;
                            table.ColumnCount = 6;

                            Label label = new Label();
                            label.Text = barcode;
                            label.Name = barcodeandindex + "Label";
                            label.Margin = new Padding(3, 6, 3, 3);

                            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                            table.Controls.Add(label, 0, 0);
                            table.ColumnStyles[0].Width = 100;

                            Button reducebutton = new Button();
                            reducebutton.Name = barcodeandindex + "ReduceButton";
                            reducebutton.Size = new Size(20, 20);
                            reducebutton.Text = "<";
                            reducebutton.Click += Reducebutton_Click;

                            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                            table.Controls.Add(reducebutton, 1, 0);
                            table.ColumnStyles[1].Width = 25;

                            TextBox counttextbox = new TextBox();
                            counttextbox.Name = barcodeandindex + "Count";
                            counttextbox.Size = new Size(40, 20);
                            counttextbox.Text = "1";
                            counttextbox.TextChanged += CountTextBox_TextChanged;

                            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                            table.Controls.Add(counttextbox, 2, 0);
                            table.ColumnStyles[2].Width = 40;

                            Button increasebutton = new Button();
                            increasebutton.Name = barcodeandindex + "IncreaseButton";
                            increasebutton.Size = new Size(20, 20);
                            increasebutton.Text = ">";
                            increasebutton.Click += Increasebutton_Click;

                            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                            table.Controls.Add(increasebutton, 3, 0);
                            table.ColumnStyles[3].Width = 50;

                            Label reasonlabel = new Label();
                            reasonlabel.Name = barcodeandindex + "ComboBox";
                            reasonlabel.Text = WriteOffReasonComboBox.Items[WriteOffReasonComboBox.SelectedIndex].ToString();
                            reasonlabel.Margin = new Padding(3, 6, 3, 3);

                            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                            table.Controls.Add(reasonlabel, 4, 0);
                            table.ColumnStyles[4].Width = 150;

                            Button removebutton = new Button();
                            removebutton.Name = barcodeandindex + "Remove";
                            removebutton.Size = new Size(100, 20);
                            removebutton.Text = "Remove";
                            removebutton.Click += Removebutton_Click;

                            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                            table.Controls.Add(removebutton, 5, 0);
                            table.ColumnStyles[5].Width = 500;

                            LayoutPanel1.Controls.Add(table);


                        }
                        else
                        {
                            foreach (TableLayoutPanel table in LayoutPanel1.Controls)
                            {
                                if (table.Name == barcodeandindex + "Table")
                                {
                                    foreach (Control control in table.Controls)
                                    {
                                        if (control.Name == barcodeandindex + "Count")
                                        {
                                            control.Text = (int.Parse(control.Text) + 1).ToString();
                                            break;
                                        }
                                    }
                                    break;
                                }

                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid Barcode");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input");
                }
            }
        }

        private void CountTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox inputtextbox = sender as TextBox;
            if(!Regex.IsMatch(inputtextbox.Text, RegExFormats.anynumber))
            {
                MessageBox.Show("Invalid input");
                inputtextbox.Text = "1";
                inputtextbox.SelectionStart = 1;
            }
        }

        private void Removebutton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string barcode = button.Name.Split('R')[0];
            
            for(int i = 0; i < LayoutPanel1.Controls.Count; i++)
            {
                if (LayoutPanel1.Controls[i].Name == barcode + "Table")
                {
                    LayoutPanel1.Controls[i].Dispose();
                    break;
                }
            }
        }

        private void Increasebutton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string barcode = button.Name.Split('I')[0];
            foreach (TableLayoutPanel table in LayoutPanel1.Controls)
            {
                if (table.Name == barcode + "Table")
                {
                    foreach (Control control in table.Controls)
                    {
                        if (control.Name == barcode + "Count")
                        {
                            control.Text = (int.Parse(control.Text) + 1).ToString();
                            break;
                        }
                    }
                    break;
                }

            }
        }

        private void Reducebutton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string barcode = button.Name.Split('R')[0];
            foreach (TableLayoutPanel table in LayoutPanel1.Controls)
            {
                if (table.Name == barcode + "Table")
                {
                    foreach (Control control in table.Controls)
                    {
                        if (control.Name == barcode + "Count")
                        {
                            int calc = int.Parse(control.Text) - 1;
                            if (calc > 0)
                            {
                                control.Text = calc.ToString();
                            }
                            break;
                        }
                    }
                    break;
                }

            }
        }

        private bool CheckDuplicatesInList(string input)
        {
            foreach(TableLayoutPanel table in LayoutPanel1.Controls)
            {
                if(table.Name == input + "Table")
                {
                    return true;
                }
            }
            return false;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> barcodes = new Dictionary<string, int>();
            string tempbarcode; ;
            foreach(TableLayoutPanel table in LayoutPanel1.Controls)
            {
                int count = int.Parse(table.Controls[2].Text);
                tempbarcode = table.Name.Split('_')[0];
                if (barcodes.ContainsKey(tempbarcode))
                {
                    barcodes[tempbarcode] += count;
                }
                else
                {
                    barcodes[tempbarcode] = count;
                }
            }
            bool valid = true;
            foreach(string key in barcodes.Keys)
            {
                if(!CheckValidWriteOffAmounts(key, barcodes[key]))
                {
                    valid = false;
                    MessageBox.Show($"Cannot write off {barcodes[key]} counts of {key}");
                }
            }

            if (valid)
            {
                List<string> actionsneeded = new List<string>();
                Forms.conn.Open();
                foreach (TableLayoutPanel table in LayoutPanel1.Controls)
                {
                    int count = int.Parse(table.Controls[2].Text);
                    string barcode = table.Name.Split('_')[0];
                    SQLiteCommand sql = new SQLiteCommand($"UPDATE Products SET StockCount = (StockCount - {count}) WHERE Barcode = {barcode}", Forms.conn);
                    sql.ExecuteNonQuery();
                    actionsneeded.Add($"{count} of {barcode} written off");
                }
                Forms.conn.Close();
                foreach(string action in actionsneeded)
                {
                    Forms.viewemployeeactions.Action(1, action);
                }
                MessageBox.Show("Items successfully written off");
                Forms.mainmenu.Show();
                Forms.stockwriteoff = new StockWriteOff();
                this.Dispose();
            }
        }

        private bool CheckValidWriteOffAmounts(string barcode, int value)
        {
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"SELECT StockCount FROM Products WHERE Barcode = {barcode}", Forms.conn);
            SQLiteDataReader reader = sql.ExecuteReader();
            bool valid = false;
            if (reader.Read())
            {
                if (Convert.ToInt32(reader["StockCount"]) >= value)
                {
                    valid = true; 
                }
                else
                {
                    valid = false;
                }
            }
            reader.Close();
            Forms.conn.Close();
            return valid;
        }
    }
}
