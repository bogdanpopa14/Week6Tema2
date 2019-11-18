using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Person
    {
        private string Name;
        public int? Age;
        public Person(string nume)
        {
            
            
                //this.Age = age;
            
            this.Name = nume;
        }
        public override string ToString()
        {
            if (this.Age == null)
                return this.Name + " varsta nespecificata";
            else return $"{this.Name} {this.Age}";
        }
    }
}
