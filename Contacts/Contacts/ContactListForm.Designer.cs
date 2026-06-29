namespace Contacts
{
    partial class ContactListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxContacts = new System.Windows.Forms.ListBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonChangeFormMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxContacts
            // 
            this.listBoxContacts.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBoxContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.listBoxContacts.FormattingEnabled = true;
            this.listBoxContacts.ItemHeight = 18;
            this.listBoxContacts.Location = new System.Drawing.Point(157, 0);
            this.listBoxContacts.Name = "listBoxContacts";
            this.listBoxContacts.Size = new System.Drawing.Size(273, 450);
            this.listBoxContacts.TabIndex = 6;
            // 
            // buttonDel
            // 
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDel.Location = new System.Drawing.Point(12, 333);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(125, 41);
            this.buttonDel.TabIndex = 8;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click_1);
            // 
            // buttonChangeFormMain
            // 
            this.buttonChangeFormMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeFormMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonChangeFormMain.Location = new System.Drawing.Point(12, 397);
            this.buttonChangeFormMain.Name = "buttonChangeFormMain";
            this.buttonChangeFormMain.Size = new System.Drawing.Size(125, 41);
            this.buttonChangeFormMain.TabIndex = 9;
            this.buttonChangeFormMain.Text = "На главную";
            this.buttonChangeFormMain.UseVisualStyleBackColor = true;
            this.buttonChangeFormMain.Click += new System.EventHandler(this.buttonChangeFormMain_Click);
            // 
            // ContactListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.buttonChangeFormMain);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.listBoxContacts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ContactListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxContacts;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonChangeFormMain;
    }
}