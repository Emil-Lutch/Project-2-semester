using System;

namespace Contacts
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
            return $"{Name};{Surname};{Number}";
        }
        public override string ToString()
        {
            return $"{Name} {Surname} ({Number})";
        }
    }
}