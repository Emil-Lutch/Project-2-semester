using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Contact
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }
        public Contact(string name, string surname, string number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }
        public string GetFullInfo()
        {
            return $"{Name} {Surname} {Number}";
        }
    }
}
