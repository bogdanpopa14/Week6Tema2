using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    enum Specialities { Inginer,Info,Doctor}
    enum Universities { Asachi,Cuza,UMF}
    enum Faculties { ETTI,AC,Dentara}

    class Student:ICloneable,IComparable<Student>
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MidlleName { get; set; }
        public int SSN { get; set; }
        public string Adress { get; set; }
        public int MobilePhone { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public Specialities Specialitate { get; set; }
        public Universities Universitate { get; set; }
        public Faculties Facultate { get; set; }
        
        public object Clone()
        {
            Student s = new Student();
            s.LastName = this.LastName;
            s.FirstName = this.FirstName;
            s.MidlleName = this.MidlleName;
            s.SSN = this.SSN;
            s.Adress = this.Adress;
            s.MobilePhone = this.MobilePhone;
            s.Email = this.Email;
            s.Course = this.Course;
            s.Specialitate = this.Specialitate;
            s.Universitate = this.Universitate;
            s.Facultate = this.Facultate;
            return s;
                
        }

        public int CompareTo(Student s)
        {
            string sfn = s.FirstName + " " + this.MidlleName + " " + this.LastName;
            string fn = this.FirstName + " " + this.MidlleName + " " + this.LastName;
            if (fn == sfn)
            {
                return this.SSN.CompareTo(s.SSN);
            }
            return fn.CompareTo(sfn);
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            if (student == null)
                return false;
            if (!(student.FirstName == this.FirstName))
                return false;
            if (!(student.LastName == this.LastName))
                return false;
            if(!(student.MidlleName==this.MidlleName))
                return false;
            if (!(student.Adress == this.Adress))
                return false;
            if (!(student.SSN == this.SSN))
                return false;
            if (!(student.MobilePhone == this.MobilePhone))
                return false;
            if (!(student.Email == this.Email))
                return false;
            if (!(student.Course == this.Course))
                return false;
            if (!(student.Specialitate == this.Specialitate))
                return false;
            if (!(student.Universitate == this.Universitate))
                return false;
            if (!(student.Facultate == this.Facultate))
                return false;
            return true;
        }

        public override int GetHashCode()
        {
            var hashCode = -684685926;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LastName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FirstName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MidlleName);
            hashCode = hashCode * -1521134295 + SSN.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Adress);
            hashCode = hashCode * -1521134295 + MobilePhone.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Course);
            hashCode = hashCode * -1521134295 + Specialitate.GetHashCode();
            hashCode = hashCode * -1521134295 + Universitate.GetHashCode();
            hashCode = hashCode * -1521134295 + Facultate.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Student s1,Student s2)
        {
            return Equals(s1,s2);
        }

        public static bool operator !=(Student s1, Student s2)
        {
            return s1.Equals(s2);
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.MidlleName + " " + this.LastName + " " + this.SSN; 
        }
    }
}
