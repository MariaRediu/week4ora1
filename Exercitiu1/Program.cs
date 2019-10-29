using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu1
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Author();
            client.Nume = "Maria";
            client.Email = "maria.mar@yahoo.com";
            client.Country = "Ro";

            var carte = new Book();
            carte.Nume = "Prima carte";
            carte.Year = 1999;
            carte.Price = 200;

            carte.Author = client;
        

            Console.WriteLine(client.AllDetails);
            client.Print();
        }
    }
}
