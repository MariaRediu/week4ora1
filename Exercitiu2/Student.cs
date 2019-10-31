using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu2
{
   public class Student
    {
        public string Nume { get; set; }
        public string Faculty { get; set; }
        public int Year { get; set; }
        public void Print()
        {
            Console.WriteLine($" Nume={this.Nume}; Faculty={this.Faculty}; Year={this.Year};");
            Console.ReadLine();
        }
    }
}
