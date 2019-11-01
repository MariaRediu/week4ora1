using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu5
{
    class Program
    {
        static void Main(string[] args)
        {
             Pizza p = new Pizza();
             p.Name = "Smille";


             PizzaBase baza = new PizzaBase();
             baza.Name = "Regular";
             baza.Cost = 30;

            p.Print();
            baza.Print();

            List<PizzaTopping> top = new List<PizzaTopping>();

            PizzaTopping topping1 = new PizzaTopping();
            
            topping1.Name= "Cheese";
            top.Add(topping1);

            topping1.Cost = 10;

            PizzaTopping topping2 = new PizzaTopping();
            topping2.Name = "Meat"; 
            top.Add(topping2);
            topping2.Cost = 20;

            PizzaTopping topping3 = new PizzaTopping();
            topping3.Name = "Vegetable";
            top.Add(topping3);
            topping3.Cost = 40;
            Console.WriteLine("Toppings:");
            foreach (var item in top)
            {
                Console.WriteLine($"\b\b\b {item.Name} (${item.Cost}) ");

            }
            Console.WriteLine($"Total cost: $ {topping1.Cost+topping2.Cost+topping3.Cost}");

            Console.ReadLine();





        }
    }
}
