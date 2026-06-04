using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class ContactForm : Form
    {
        CheckInfo info = new CheckInfo();
        public ContactForm()
        {
            InitializeComponent();
            info.LoadFromTxt("contacts.txt");
            RefreshContacts();
        }
        private void RefreshContacts()
        {
            listBoxContacts.DataSource = null;

            listBoxContacts.DataSource =
                info.GetContacts();
        }
        private void ContactForm_Load(object sender, EventArgs e)
        {

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Contact c = new Contact(textBoxName.Text, textBoxSurname.Text, textBoxNumber.Text);
            info.AddCon(c);
            info.SaveToTxt("contacts.txt");
            RefreshContacts();
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxNumber.Clear();
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            Contact selected = (Contact)listBoxContacts.SelectedItem;

            if (selected == null)
                return;
            info.RemoveCon(selected.Number);
            info.SaveToTxt("contacts.txt");
            RefreshContacts();
        }

    }
}
