using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu5
{
   public class Pizza
    {
        public string Name { get; set; }
       // public List<PizzaTopping> toppings { get; set; }

        public PizzaBase PizzaBase { get; set; }

        public void AddTopping(string topping)
        {
           
        }
        public void Print() { 
            Console.WriteLine($"Pizza:{this.Name}"); 
        }

       // public void CalculateTotalCost();      
      


    }
}
