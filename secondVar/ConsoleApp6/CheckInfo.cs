using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class CheckInfo
    {
        public List<Contact> Contacts = new List<Contact>();
        public void AddCon(Contact contact)
        {
            Contacts.Add(contact);
        }
        public void RemoveCon(string number)
        {
            Contacts.RemoveAll(contact  => contact.Number == number); 
        }
        public void ShowAllCon()
        {
            
        }
    }
}
