using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
   public class Room
    {

        public string  Name { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
        public Rate DailyRate { get; set; }

        public void  GetPriceForDays(int numberOfDays)
        {

            Console.WriteLine($"Pentru numaul de zile {numberOfDays} pretul este: {DailyRate.Amount * numberOfDays} {DailyRate.Currency}");
        

    }
    public void Print()
        {
            Console.WriteLine($"Nume={this.Name}- Rate={this.DailyRate}  Adults={this.Adults}  Children={this.Children}");

            Console.ReadLine();
        }

    }
}
