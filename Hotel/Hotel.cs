using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
   public class Hotel
    {
        public string Name { get; set; }
        public string City { get; set; }
        public List <Room>  ListOfRoom { get; set; }
        public int Stars { get; set; }

        /* public string Print() {
             string array = "";
             foreach (var cam in ListOfRoom)
             {
                 array += $"{cam.Print()}\r\n";
             }
             return 
             Console.WriteLine(($"Name={this.Name} City={this.City}  Stars= {this.Stars} -\r\n{array.ToString()} ");
         }*/
        public string Print()
        {
            string sir = "";
            foreach (var item in ListOfRoom)
            {
                sir += $"{item.Print()}\r\n";
            }
            return $"Hotel:{Name} - Oras {City} -  Stele {Stars}-\r\n{sir.ToString()}";
        }
    }
}
