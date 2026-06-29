using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Contacts
{
    public partial class ContactForm : Form
    {
        CheckInfo info = new CheckInfo();

        public ContactForm()
        {
            InitializeComponent();
            info.LoadFromTxt("contacts.txt");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            string number = textBoxNumber.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(number))
            {
                MessageBox.Show("Поля не заполнены");
                return;
            }
            Contact c = new Contact(
                textBoxName.Text,
                textBoxSurname.Text,
                textBoxNumber.Text);

            info.AddCon(c);
            info.SaveToTxt("contacts.txt");

            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxNumber.Clear();

            ContactListForm contactList = new ContactListForm(info, this);
            contactList.Show();
            this.Hide();
        }
        private void buttonFormChange_Click(object sender, EventArgs e)
        {
            ContactListForm contactList = new ContactListForm(info, this);
            contactList.Show();
            this.Hide();
        }
    }
}