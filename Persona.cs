﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructors
{
    internal class Persona
    {
        public string Name { get; set; }  
        public string Surname { get; set; }
        public int Age { get; set; }

        public string getDetails()
        {
            return Name + " " + Surname + " | età= " + Age;
        }

        public Persona() { }

        public Persona(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
