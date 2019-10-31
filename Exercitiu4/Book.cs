using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu4
{
    class Book
    {
        public int _price;
        public string name;

        public string Author { get; set; }
        public string Title { 
            get
                { return name;  }

            set {

                if (!string.IsNullOrEmpty(name))
                {
                    name = char.ToUpper(name[0]) + name.Substring(1);
                }
                name = value;
                }

                            }
        public double Price {

            get{
                return _price;
                }
            set { 
               if (_price == 1.5)
                {
                   
                    Console.WriteLine("This book is regular book!!"); }
                }
        }

        public void Print()
        {
            Console.WriteLine($"Author={this.Author}- Title={this.Title}  Price={this.Price}");

            
            Console.WriteLine();
        }
    }
}
