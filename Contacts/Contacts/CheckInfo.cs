using Contacts;
using System;
using System.Collections.Generic;
using System.IO;

namespace Contacts
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
            Contacts.RemoveAll(c => c.Number == number);
        }
        public void ShowAllCon()
        {
            foreach (Contact contact in Contacts)
            {
                Console.WriteLine(contact);
            }
        }
        public void SaveToTxt(string path)
        {
            List<string> lines = new List<string>();

            foreach (Contact contact in Contacts)
            {
                lines.Add(contact.GetFullInfo());
            }

            File.WriteAllLines(path, lines);
        }
        public void LoadFromTxt(string path)
        {
            Contacts.Clear();

            if (!File.Exists(path))
                return;

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string[] data = line.Split(';');

                if (data.Length == 3)
                {
                    Contact contact =
                        new Contact(
                            data[0],
                            data[1],
                            data[2]);

                    Contacts.Add(contact);
                }
            }
        }
        public List<Contact> GetContacts()
        {
            return Contacts;
        }
    }
}