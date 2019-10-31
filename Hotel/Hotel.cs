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
        public Room ListOfRoom { get; set; }

        public void GetPriceForNumberOfRooms(int numberOfRooms)
        {
            Console.WriteLine($"Pentru numarul de camere {numberOfRooms} pretul este { GetPriceForDays()* numberOfRooms });
        }
        public void Print() {
            Console.WriteLine(($"Name={this.Name} City={this.City} List={this.ListOfRoom} ");
        }
    }
}
