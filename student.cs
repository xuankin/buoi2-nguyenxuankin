using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hhih
{
    internal class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor to initialize Student
        public student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        // Override ToString to display student info
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}";
        }
    }

   
 }

