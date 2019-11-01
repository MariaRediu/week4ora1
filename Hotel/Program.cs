using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel1 = new Hotel();

            hotel1.Name = "Select";
            hotel1.City = "Iasi";
            hotel1.ListOfRoom = 1;

            Room camera = new Room();
            camera.Name = "Camera_1";
            camera.Adults = 1;
            camera.Children = 2;
           // Console.WriteLine("")
            
        }
    }
}
