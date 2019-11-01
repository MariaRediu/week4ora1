using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu5
{
   public class PizzaBase
    {
        public string Name { get; set; } // Regular, Thick, Italian
        public int Cost { get; set; }
        public void Print()
        {
            Console.WriteLine($"Base={this.Name} - {this.Cost}");

            Console.ReadLine();
        }
    }
}
