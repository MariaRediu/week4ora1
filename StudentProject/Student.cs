using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject
{
    public class Student
    {
        string nume;
        string prenume;
        string cnp;

        /* public Student(string x,string y)
          {
              this.nume = x;
              this.prenume = y;
          }*/

        public string Nume
        {
            get { return nume; }
            set { nume = value; }

        }
        public string Prenume
        {
            get { return prenume; }
            set { prenume = value; }
        }

        //dinamyc property &read only
        internal string FullDescription
        {
            get { return $"{Nume} - {Prenume}"; }
        }
        public string Cnp
        {
            get { return cnp; }
            set { Cnp = value; }
        }

        public void Print()
        {
            System.Console.WriteLine($"nume={ this.nume}, prenume={this.prenume}");
            Console.ReadLine();
        }
    }

    public class Curs
    {
        public void AddStudent(Student s)
        {
            Console.WriteLine(s.FullDescription);
        }
    }
}
