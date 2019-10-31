using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu2
{
    public class Course

    {
        public string Nume { get; set; }
        public string Profesor { get; set; }
        public int Year { get; set; }
       
        public void Print()
        {
            Console.WriteLine($" Detalii curs: Nume={this.Nume}; Profesor={this.Profesor}; Year={this.Year};");
            Console.ReadLine();

        }
    }
}
