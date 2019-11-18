using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student { Adress = "Strada", Course = "Curs", Email = "ss@.com", Facultate = Faculties.AC, FirstName = "A", LastName = "B", MidlleName = "C", MobilePhone = 07412123, Specialitate = Specialities.Info, SSN = 1, Universitate = Universities.Cuza };
            var s2 = s.Clone();
            var s3 = new Student { Adress = "Strada", Course = "Curs", Email = "ss@.com", Facultate = Faculties.AC, FirstName = "B", LastName = "B", MidlleName = "C", MobilePhone = 07412123, Specialitate = Specialities.Info, SSN = 1, Universitate = Universities.Cuza };
            // s.Facultate = Faculties.Dentara;
            var b = Equals(s, s3);
            //s.Facultate = Faculties.Dentara;
            if (s==s3) { }
            var s4 = new Student { Adress = "Strada", Course = "Curs", Email = "ss@.com", Facultate = Faculties.AC, FirstName = "B", LastName = "B", MidlleName = "C", MobilePhone = 07412123, Specialitate = Specialities.Info, SSN = 2, Universitate = Universities.Cuza };
            var s5 = new Student { Adress = "Strada", Course = "Curs", Email = "ss@.com", Facultate = Faculties.AC, FirstName = "B", LastName = "N", MidlleName = "C", MobilePhone = 07412123, Specialitate = Specialities.Info, SSN = 2, Universitate = Universities.Cuza };
            var s6 = new Student { Adress = "Strada", Course = "Curs", Email = "ss@.com", Facultate = Faculties.AC, FirstName = "A", LastName = "D", MidlleName = "C", MobilePhone = 07412123, Specialitate = Specialities.Info, SSN = 3, Universitate = Universities.Cuza };
            var i=s.CompareTo(s3);
            List<Student> lista = new List<Student>();
            lista.Add(s);
            lista.Add(s3);
            lista.Add(s4);
            lista.Add(s5);
            lista.Add(s6);
            lista.Sort();
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
