using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu1
{
    class Book
    {
        public string Nume { get; set; }
        public  Author Author { get; set; }
        public int Year { get; set; }

        public double Price { get; set; }

       public void Print()
        {
            Console.WriteLine($"Book={this.Nume}- Year={this.Year}  Price={this.Price}");
            Author.Print();
            Console.WriteLine();
        }
    }
}
