using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu2
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Student> studenti = new List<Student>();

            Student student1 = new Student();


            student1.Nume = "Ana";
            student1.Faculty = "AC";
            student1.Year = 1;

            Student student2 = new Student();
            student2.Nume = "Ioana";
            student2.Faculty = "Info";
            student2.Year = 3;

            studenti.Add(student1);
            studenti.Add(student2);

            foreach (var item in studenti)
            {
                Console.WriteLine("Lista de studentii: Nume={0},Faculty={1} ,Year={2}", item.Nume, item.Faculty, item.Year);
                
            }

            var profesor = new Professor();
            profesor.Nume = "Popescu";
            profesor.Specialization = "IT";
            profesor.Faculty = "Info";

       

            var curs = new Course();
            curs.Nume = "Matematica";
            curs.Profesor = "Ionescu";
            curs.Year = 4;


            Console.ReadLine();


             profesor.Print();
             curs.Print();
        }
    }
}
