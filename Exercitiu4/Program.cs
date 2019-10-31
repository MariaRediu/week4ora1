using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu4
{
    class Program
    {
        static void Main(string[] args)
        {
            Book carte1 = new Book();

            carte1.Author = "Ion Creanga";
            carte1.Title = "amintiri din copilarie";
            carte1.Price = 2;


            Book carte2 = new Book();

            carte2.Author = "Mihai Eminescu";    
            carte2.Title = "sara pe deal";
            carte2.Price = 1.5;


            Book carte3 = new Book();

            carte3.Author = "Mihail Sadoveanu";
            carte3.Title = "baltagul";
            carte3.Price = 4.5;


            Book carte4 = new Book();

            carte4.Author = "Ioan Slavici";
            carte4.Title = "mara";
            carte4.Price = 10;

            Book carte5 = new Book();

            carte5.Author = "Marin Preda";
            carte5.Title = "ion";
            carte5.Price = 30;

            List<Book> carti = new List<Book>();
            carti.Add(carte1);
            carti.Add(carte2);
            carti.Add(carte3);
            carti.Add(carte4);
            carti.Add(carte5);
            foreach (var item in carti)
            {
                Console.WriteLine("Lista de cartii este: Author={0} ,Title={1} ,Price  ={2}", item.Author, item.Title, item.Price);
                Console.ReadLine();
            }


        }
    }
}
