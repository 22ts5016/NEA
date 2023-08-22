using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_IT
{
    internal class LetterNotFoundException : Exception
    {
        public LetterNotFoundException() : base(String.Format("Word not found"))
        {
        }
    }
}
