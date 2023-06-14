using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_bar_and_autofill_1
{
    internal class LetterNotFoundException : Exception
    {
        public LetterNotFoundException() : base(String.Format("Word not found"))
        {
        }
    }
}
