using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu2
{
   public  class Professor
    {
        public string Nume { get; set; }
        public string Faculty { get; set; }
        public string Specialization { get; set; }
        public void Print()
        {
            Console.WriteLine($" Detalii profesor : Nume={this.Nume} Faculty={this.Faculty} Specialization={this.Specialization}");
        }
    }
}
