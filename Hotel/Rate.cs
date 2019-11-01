using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Rate
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }

        public string Print
        {
            get { return $"Rate:{Amount} - {Currency}"; }
        }
    }
}
