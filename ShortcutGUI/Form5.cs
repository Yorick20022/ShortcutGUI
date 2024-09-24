using System;
using System.Windows.Forms;
using ShortcutGUI.models;
using SQLite;

namespace ShortcutGUI
{
    public partial class Form5 : Form
    {
        public Form5()
        {

            InitializeComponent();
            ChangeTreshold();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            var db = new SQLiteConnection("./shortcut.db");
            var config = db.Table<Config>().FirstOrDefault();
            if (config == null)
            {
                this.comboBox2.Text = "0";
            }
            else
            {
                this.comboBox2.Text = config.MostUsedTreshold.ToString();
            }

        }

        private void BackIcon_Click(object sender, EventArgs e)
        {
            this.Close();
            var mainMenu = new Form1();
            mainMenu.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ChangeTreshold()
        {
            var db = new SQLiteConnection("./shortcut.db");

            // Fetch the existing record, or create a new one if none exists
            var config = db.Table<Config>().FirstOrDefault();

            if (config == null)
            {
                // Create a new Config object if no existing record is found
                config = new Config();
                Console.WriteLine("New config created because no existing record was found.");
                db.Insert(config); // Insert the new config into the database
            }

            // Use switch to set the value based on selected index
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    config.MostUsedTreshold = 5;
                    break;
                case 1:
                    config.MostUsedTreshold = 10;
                    break;
                case 2:
                    config.MostUsedTreshold = 15;
                    break;
                case 3:
                    config.MostUsedTreshold = 20;
                    break;
            }

            // Update the record in the database
            db.Update(config);

            // Close the DB connection
            db.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeTreshold();
        }

        private void btnChangeMode_Click(object sender, EventArgs e)
        {
        }
    }
}

