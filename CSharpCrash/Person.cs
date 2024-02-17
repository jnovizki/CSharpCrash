using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCrash
{
    public class Person
    {
        // fields
        private string name;
        private int age;

        // Constructors
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Properties. Accesors to private fields
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        //ALTERNATIVE WAY TO ACCESS PROPERTIES. No requiere invocar al Constructor con parametros
        //public string Name { get ; set }
        //public int Age { get; set; }

        //Methods of the object
        public void Greet()
        {
            Console.WriteLine($"Hello. My name is {Name}. My age is {Age}");
        }
    }
}
