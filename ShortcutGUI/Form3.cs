using System;
using System.Windows.Forms;
using ShortcutGUI.models;
using SQLite;

namespace ShortcutGUI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void ConfirmAddNewButton_Click(object sender, EventArgs e)
        {
            var db = new SQLiteConnection("./shortcut.db");

            string shortcutName = this.ShortcutTextbox.Text;
            string textContent = this.TextTextBox.Text;

            var data = new Shorts()
            {
                ShortCutName = shortcutName,
                ShortCutText = textContent
            };

            if (string.IsNullOrWhiteSpace(ShortcutTextbox.Text))
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(TextTextBox.Text))
            {
                return;
            }

            try
            {
                db.Insert(data);
                label5.ForeColor = System.Drawing.Color.Green;
                label5.Text = "Shortcut successfully created";
                this.ShortcutTextbox.Clear();
                this.TextTextBox.Clear();
                db.Close();
            }
            catch (SQLiteException)
            {
                label5.ForeColor = System.Drawing.Color.Red;
                label5.Text = "That shortcut already exists";
                return;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            var mainMenu = new Form1();
            mainMenu.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
