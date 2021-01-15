using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowControlWebHost.MVCUI
{
    public class Exhibit01
    {
        public string Message { get; set; }

        private string _paddedNumber;

        public string PaddedNumber
        {
            get
            {
                string fmt = "000";
                string output = Number.ToString(fmt);
                return output;
            }
            set
            {
                _paddedNumber = value;
            }
        }

        public int Number { get; set; } 

    }
}