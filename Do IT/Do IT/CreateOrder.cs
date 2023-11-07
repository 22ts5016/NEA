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
using System.IO;
using System.Text.RegularExpressions;

namespace Do_IT
{
    public partial class CreateOrder : Form
    {
        public List<string> barcodesinorder = new List<string>();
        public List<int> quantityofproducts = new List<int>();
        private List<bool> confirmedquantities = new List<bool>();
        public bool customertagged = false;
        private double totalcost = 0;
        private int customerID = 0;
        private int orderID = 0;
        private int ordertype = 0;

        public CreateOrder()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mainmenu.Show();
            this.Hide();
        }

        private void ProductQueryButton_Click(object sender, EventArgs e)
        {
            if(Forms.productquery == null)
            {
                Forms.productquery = new ProductQuery();
            }
            Forms.productquery.ViewOrderButton.Visible = true;
            Forms.productquery.Show();
            this.Hide();
        }

        public void AddCustomerToOrder(int inputcustomerID)
        {
            customerID = inputcustomerID;
            customertagged = true;
            SelectCustomerButton.Visible = false;
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"SELECT * FROM Customers WHERE CustomerID = '{customerID}'", Forms.conn);
            SQLiteDataReader reader = sql.ExecuteReader();
            reader.Read();
            Forms.vieworder.AddInfoToOrderDisplay(ref DetailsTableLayoutPanel, reader, false);
            reader.Close();

            SQLiteCommand sql2 = new SQLiteCommand($"SELECT OrderType FROM OrderTypes", Forms.conn);
            SQLiteDataReader reader2 = sql2.ExecuteReader();
            ComboBox ordertypecombobox = new ComboBox();
            ordertypecombobox.Name = "OrderTypeComboBox";
            ordertypecombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            ordertypecombobox.Anchor = AnchorStyles.Top;
            while (reader2.Read())
            {
                ordertypecombobox.Items.Add((string)reader2["OrderType"]);
            }

            DetailsTableLayoutPanel.Controls.Add(ordertypecombobox, 8, 1);
            Forms.conn.Close();
        }

        private void SelectCustomerButton_Click(object sender, EventArgs e)
        {
            Forms.viewcustomer.Show();
            this.Hide();
        }

        public void DisplayItemsInOrder()
        {
            MainLayoutPanel.Controls.Clear();
            totalcost = 0;
            if(barcodesinorder.Count != 0)
            {
                string soflistofbarcodes = "(";
                foreach (string barcode in barcodesinorder)
                {
                    soflistofbarcodes += barcode + ", ";
                }
                soflistofbarcodes = soflistofbarcodes.Substring(0, soflistofbarcodes.Length - 2);
                soflistofbarcodes += ')';
                Forms.conn.Open();
                SQLiteCommand sql = new SQLiteCommand($"SELECT Barcode, ProductName, Price, Image FROM Products WHERE Barcode IN {soflistofbarcodes}", Forms.conn);
                SQLiteDataReader reader = sql.ExecuteReader();

                while (reader.Read())
                {
                    string barcode = (string)reader["Barcode"];
                    string productname = (string)reader["ProductName"];
                    double totalprice = Convert.ToDouble(reader["Price"]) * quantityofproducts[barcodesinorder.IndexOf(barcode)];

                    TableLayoutPanel table = new TableLayoutPanel();

                    table.Name = barcode + "_Table";
                    table.Size = new Size(1300, 142);
                    table.ColumnCount = 8;
                    table.RowCount = 1;

                    PictureBox image = new PictureBox();
                    image.Size = new Size(142, 142);
                    image.SizeMode = PictureBoxSizeMode.Zoom;
                    image.Image = new Bitmap(new MemoryStream((byte[])reader["Image"]));
                    image.Name = barcode + "_PictureBox";

                    table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                    table.Controls.Add(image, 0, 0);
                    table.ColumnStyles[0].Width = 142;

                    Label temp;

                    temp = Forms.vieworder.CreateLabel("middle");
                    temp.Text = barcode;
                    temp.Name = barcode + "_Label";

                    table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                    table.Controls.Add(temp, 1, 0);
                    table.ColumnStyles[1].Width = 158;

                    temp = Forms.vieworder.CreateLabel("middle");
                    temp.Text = productname;
                    temp.Name = productname + "_Label";

                    table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                    table.Controls.Add(temp, 2, 0);
                    table.ColumnStyles[2].Width = 450;

                    TextBox quantity = new TextBox();
                    quantity.Text = quantityofproducts[barcodesinorder.IndexOf(barcode)].ToString();
                    quantity.Name = barcode + "_Quantity_TextBox";
                    quantity.Anchor = AnchorStyles.None;
                    quantity.ReadOnly = true;

                    table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                    table.Controls.Add(quantity, 3, 0);
                    table.ColumnStyles[3].Width = 100;

                    Button editorconfirmbutton = new Button();
                    editorconfirmbutton.Text = "Edit";
                    editorconfirmbutton.Name = barcode + "_EditOrConfirm_Button";
                    editorconfirmbutton.Size = new Size(80, 20);
                    editorconfirmbutton.Anchor = AnchorStyles.None;
                    editorconfirmbutton.Click += EditOrConfirmButton_Click;

                    table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                    table.Controls.Add(editorconfirmbutton, 4, 0);
                    table.ColumnStyles[4].Width = 100;

                    temp = Forms.vieworder.CreateLabel("middle");
                    temp.Text = '£' + Convert.ToDouble(reader["Price"]).ToString();
                    temp.Name = barcode + "_Price_Label";

                    table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                    table.Controls.Add(temp, 5, 0);
                    table.ColumnStyles[5].Width = 100;


                    temp = Forms.vieworder.CreateLabel("middle");
                    totalcost += totalprice;
                    temp.Text = '£' + totalprice.ToString();
                    temp.Name = barcode + "_TotalPrice_Label";

                    table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                    table.Controls.Add(temp, 6, 0);
                    table.ColumnStyles[6].Width = 150;

                    Button removebutton = new Button();
                    removebutton.Text = "Remove";
                    removebutton.Name = barcode + "_Remove_Button";
                    removebutton.Size = new Size(80, 20);
                    removebutton.Anchor = AnchorStyles.None;
                    removebutton.Click += RemoveButton_Click;

                    table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                    table.Controls.Add(removebutton, 7, 0);
                    table.ColumnStyles[7].Width = 100;

                    confirmedquantities.Add(true);

                    MainLayoutPanel.Controls.Add(table);
                }
                TotalCostLabel.Text = "Total Cost: £" + totalcost.ToString();
                SetTotalProductCount();
                reader.Close();
                Forms.conn.Close();
            }
        }

        private void EditOrConfirmButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string barcode = button.Name.Split('_')[0];
            double price = 0;
            TextBox textbox = new TextBox();
            foreach (Control control in button.Parent.Controls)
            {
                if (control.Name == barcode + "_Price_Label")
                {
                    price = double.Parse(control.Text.Split('£')[1]);
                }
                if (control.Name == barcode + "_Quantity_TextBox")
                {
                    textbox = control as TextBox;
                }
            }
            if (button.Text == "Edit")
            {
                button.Text = "Confirm";
                totalcost -= price * int.Parse(textbox.Text);
                textbox.ReadOnly = false;
                confirmedquantities[barcodesinorder.IndexOf(barcode)] = false;
            }
            else
            {
                button.Text = "Edit";
                if (Regex.IsMatch(textbox.Text, RegExFormats.anynumber) && textbox.Text != "0")
                {
                    TableLayoutPanel table = (TableLayoutPanel)MainLayoutPanel.Controls[MainLayoutPanel.Controls.GetChildIndex(textbox.Parent)];
                    foreach (Control control in table.Controls)
                    {
                        if (control.Name == barcode + "_Price_Label")
                        {
                            price = double.Parse(control.Text.Split('£')[1]);
                        }
                        if (control.Name == barcode + "_TotalPrice_Label")
                        {
                            control.Text = '£' + (int.Parse(textbox.Text) * price).ToString();
                        }
                    }
                    quantityofproducts[barcodesinorder.IndexOf(barcode)] = int.Parse(textbox.Text);
                    SetTotalProductCount();
                    totalcost += price * int.Parse(textbox.Text);
                    TotalCostLabel.Text = "Total Cost: £" + totalcost.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid input");
                    textbox.Text = "1";
                    quantityofproducts[barcodesinorder.IndexOf(barcode)] = 1;
                    SetTotalProductCount();
                    foreach (Control control in textbox.Parent.Controls)
                    {
                        if (control.Name == barcode + "_TotalPrice_Label")
                        {
                            control.Text = "£" + price;
                        }
                    }
                    totalcost += price;
                    TotalCostLabel.Text = "Total Cost: £" + totalcost.ToString();
                }
                textbox.ReadOnly = true;
                confirmedquantities[barcodesinorder.IndexOf(barcode)] = true;
            }
            
        }

        private void SetTotalProductCount()
        {
            int count = 0;
            foreach(int i in quantityofproducts)
            {
                count += i;
            }
            TotalProductCountLabel.Text = "Total product Count: " + count;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string barcode = button.Name.Split('_')[0];
            foreach(TableLayoutPanel table in MainLayoutPanel.Controls)
            {
                if(table.Name == barcode + "_Table")
                {
                    int quantity = 0;
                    double price = 0;
                    foreach(Control control in table.Controls)
                    {
                        if (control.Name == barcode + "_Quantity_TextBox")
                        {
                            quantity = int.Parse(control.Text);
                        }
                        if (control.Name == barcode + "_Price_Label")
                        {
                            price = double.Parse(control.Text.Split('£')[1]);
                        }
                    }
                    totalcost -= quantity * price;
                    TotalCostLabel.Text = "Total Cost: £" + totalcost.ToString();
                    table.Dispose();
                    quantityofproducts.RemoveAt(barcodesinorder.IndexOf(barcode));
                    confirmedquantities.RemoveAt(barcodesinorder.IndexOf(barcode));
                    barcodesinorder.Remove(barcode);
                    SetTotalProductCount();
                }
            }
        }

        private void SubmitOrderButton_Click(object sender, EventArgs e)
        {
            if (customertagged)
            {
                if(barcodesinorder.Count != 0)
                {
                    foreach(bool check in confirmedquantities)
                    {
                        if (!check)
                        {
                            MessageBox.Show("Please confirm all item quantities");
                            return;
                        }
                    }
                    foreach (Control control in DetailsTableLayoutPanel.Controls)
                    {
                        if (control.Name == "OrderTypeComboBox")
                        {
                            ComboBox combobox = control as ComboBox;
                            if (combobox.SelectedIndex != -1)
                            {
                                ordertype = combobox.SelectedIndex + 1;
                                CreateNewOrder();
                                MessageBox.Show("Order placed");
                                Forms.createorder = new CreateOrder();
                                Forms.mainmenu.Show();
                                this.Dispose();
                            }
                            else
                            {
                                MessageBox.Show("Please select an order type");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please add items to the order");
                }
            }
            else
            {
                MessageBox.Show("Please select a customer account");
            }
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            Forms.createorder = new CreateOrder();
            Forms.createorder.Show();
            this.Dispose();
        }

        private void CreateNewOrder()
        {
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"INSERT INTO OrderInfo VALUES ('{orderID}', '{customerID}', '{ordertype}', '1') ", Forms.conn);
            sql.ExecuteNonQuery();
            SQLiteCommand sql2;
            for (int i = 0; i < barcodesinorder.Count; i++)
            {
                sql2 = new SQLiteCommand($"INSERT INTO OrderEntry VALUES ((SELECT MAX(EntryID) + 1 FROM OrderEntry), '{orderID}', '{barcodesinorder[i]}', '{quantityofproducts[i]}')", Forms.conn);
                sql2.ExecuteNonQuery();
            }
            Forms.conn.Close();
            Forms.viewemployeeactions.Action(3, $"Order Num: {orderID} made");
        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"SELECT MAX(OrderID) FROM OrderInfo", Forms.conn);
            SQLiteDataReader reader = sql.ExecuteReader();
            reader.Read();
            orderID = Convert.ToInt32(reader["MAX(OrderID)"]) + 1;
            OrderIDLabel.Text += orderID.ToString();
            reader.Close();
            Forms.conn.Close();
        }
    }
}
