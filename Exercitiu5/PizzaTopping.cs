using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu5
{
   public class PizzaTopping
    {
        private string name = "Meat";
        public string Name
        {
            get

            {
               

                    return name.ToUpper();

            }

            set

            {

             //  if (value == "Meat")

                    name = value;

           
                  

            }
        } // Cheese, Meat, Vegetable
        public int Cost { get; set; }
        public void Print()
        {
            Console.WriteLine($"Toppings ={this.Name}- ({this.Cost})");
        }
       
    }
}
