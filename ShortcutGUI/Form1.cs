using System;
using System.Windows.Forms;
namespace ShortcutGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FindShortcut_Click(object sender, EventArgs e)
        {
            // Logic for "find" button
            var FindShortcutWindow = new Form2();
            this.Hide();
            FindShortcutWindow.Show();

        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            // Logic for "add new" button
            var AddNewWindow = new Form3();
            this.Hide();
            AddNewWindow.Show();
        }

        private void MostUsed_Click(object sender, EventArgs e)
        {
            // Logic for "add new" button
            var AddNewWindow = new Form4();
            this.Hide();
            AddNewWindow.Show();
        }

        private void MostUsed_Click_1(object sender, EventArgs e)
        {

        }

        private void SettingsIcon_Click(object sender, EventArgs e)
        {
            var AddNewWindow = new Form5();
            this.Hide();
            AddNewWindow.Show();
        }
    }
}
