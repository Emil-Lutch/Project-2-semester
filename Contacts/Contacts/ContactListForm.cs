using System;
using System.Windows.Forms;

namespace Contacts
{
    public partial class ContactListForm : Form
    {
        private CheckInfo info;
        private ContactForm contactForm;

        public ContactListForm(CheckInfo info, ContactForm form)
        {
            InitializeComponent();

            this.info = info;
            this.contactForm = form;

            RefreshContacts();
        }

        private void RefreshContacts()
        {
            listBoxContacts.DataSource = null;
            listBoxContacts.DataSource = info.GetContacts();
        }
        private void buttonChangeFormMain_Click(object sender, EventArgs e)
        {
            contactForm.Show();
            this.Close();
        }

        private void buttonDel_Click_1(object sender, EventArgs e)
        {
            Contact s = (Contact)listBoxContacts.SelectedItem;
            if (s == null)
                return;
            info.RemoveCon(s.Number);
            info.SaveToTxt("contacts.txt");
            RefreshContacts();
        }
    }
}