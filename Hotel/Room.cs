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
        public string  Print()
        {
            return $"Room:\n {Name} :Pret: {DailyRate.Print} - Adulti: {Adults} - Copii:{Children}";
        }
            
        public decimal GetPriceForDays(int numberofdays)
        {
            return numberofdays * DailyRate.Amount;
        }

    }
}
