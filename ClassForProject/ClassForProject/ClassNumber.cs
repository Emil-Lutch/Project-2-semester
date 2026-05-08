using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassForProject
{
    internal class ClassNumber
    {
        public string Number { get; set; }
        public ClassName Contact {  get; set; }
        public ClassNumber(string number, ClassName contact) 
        {
            Number = number;
            Contact = contact;
        }
        public void GetFullInfo()
        {
            Console.WriteLine($"Name: {Contact.GetInfoName()}");
            Console.WriteLine($"Number: {Number}");
        }
    }
}
