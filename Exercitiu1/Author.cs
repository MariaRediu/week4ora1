using System;

namespace Exercitiu1
{
    class Author
    {
       
        public string Nume { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }

        public string AllDetails
        {
            get { return $"{Nume} - {Email}-{Country}"; }
        }

        public void Print()
        {
            Console.WriteLine($"Nume={this.Nume} Email={this.Email} Country={this.Country}");
        }
           
    }
}
