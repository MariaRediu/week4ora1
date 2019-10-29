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
            Console.WriteLine(client.AllDetails);
            client.Print();
        }
    }
}
