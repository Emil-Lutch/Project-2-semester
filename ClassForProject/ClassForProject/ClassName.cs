using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassForProject
{
    internal class ClassName
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public ClassName(string name, string surname) 
        {
            Name = name;
            Surname = surname;
        }
        public string GetInfoName()
        {
            return $"{Name} {Surname}";
        }
    }
}
