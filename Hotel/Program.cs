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
            Rate rate1 = new Rate();
            rate1.Amount = 100;
            rate1.Currency = "USD";

            Rate rate2 = new Rate();
            rate2.Amount = 400;
            rate2.Currency = "USD";  

            Room camera1 = new Room();
            camera1.Name = "Camera_1";
            camera1.DailyRate = rate1;
            camera1.Adults = 1;
            camera1.Children = 2;

            Room camera2 = new Room();
            camera2.Name = "Camera_2";
            camera2.DailyRate = rate1;
            camera2.Adults = 2;
            camera2.Children = 3;
            camera2.DailyRate = rate2;

            List<Room> rooms = new List<Room>();
            rooms.Add(camera1);
            rooms.Add(camera2);

            Hotel hotel1 = new Hotel();
            hotel1.Name = "Select";
            hotel1.City = "Iasi";
            hotel1.Stars = 4;
            hotel1.ListOfRoom = rooms;


            Console.WriteLine(hotel1.Print());
            Console.ReadLine();

        }
    }
}
