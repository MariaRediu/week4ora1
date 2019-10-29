using StudentProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Ora1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student stud1 = new Student("Vasile" ,"Popescu");

            //      stud1.Print();

            // Student stud2 = new Student("Ion", "Ionescu");
            //stud2.Print();

            var s = new Student();
            s.Nume = "Andrei";
            s.Prenume = "Popescu";
            s.Print();

            // s.Cnp = "123";
            //Console.WriteLine(s.FullDescription); ///cum se apeleaza o proprietate ,fara paranteze se apeleaza
        }
    }
}
