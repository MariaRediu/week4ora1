using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu5
{
   public class PizzaTopping
    {
        public string Name { get; set; } // Cheese, Meat, Vegetable
        public int Cost { get; set; }
        public void Print()
        {
            Console.WriteLine($"Toppings ={this.Name}- ({this.Cost})");
        }
       
    }
}
