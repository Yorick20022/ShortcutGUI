using System;
using System.Linq;
using System.Windows.Forms;
using ShortcutGUI.models;
using SQLite;

namespace ShortcutGUI
{
    public partial class Form2 : Form
    {
        private ListBox suggestionListBox;

        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.KeyPreview = true;

            // Initialize ListBox for suggestions
            suggestionListBox = new ListBox();
            suggestionListBox.Visible = false;
            suggestionListBox.Width = textBox2.Width;
            suggestionListBox.Top = textBox2.Bottom + 2;  // Place below the TextBox
            suggestionListBox.Left = textBox2.Left;
            suggestionListBox.Height = 50; // You can adjust the height

            // Handle the event when a suggestion is clicked
            suggestionListBox.Click += SuggestionListBox_Click;

            // Add ListBox to the form
            this.Controls.Add(suggestionListBox);
            suggestionListBox.BringToFront();
        }

        private void SuggestionListBox_Click(object sender, EventArgs e)
        {
            // Handle selection of suggestion
            if (suggestionListBox.SelectedItem != null)
            {
                textBox2.Text = suggestionListBox.SelectedItem.ToString();
                suggestionListBox.Visible = false;  // Hide after selection
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var mainMenu = new Form1();
            this.Close();
            mainMenu.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Empty event handler, can be left as is.
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Keep original functionality of logging text changes
            string inputText = textBox2.Text;
            if (string.IsNullOrEmpty(inputText))
            {
                suggestionListBox.Visible = false;
                return;
            }

            // Query the database for suggestions based on the current input
            using (SQLiteConnection db = new SQLiteConnection("./shortcut.db"))
            {
                var suggestions = db.Table<Shorts>()
                    .Where(result => result.ShortCutName.StartsWith(inputText))
                    .Select(result => result.ShortCutName)
                    .ToList();

                // Show suggestions in the ListBox
                if (suggestions.Any())
                {
                    suggestionListBox.Items.Clear();
                    suggestionListBox.Items.AddRange(suggestions.ToArray());
                    suggestionListBox.Visible = true;
                }
                else
                {
                    suggestionListBox.Visible = false;
                }
            }
        }

        private void ConfirmFindButton_Click(object sender, EventArgs e)
        {
            SQLiteConnection db = new SQLiteConnection("./shortcut.db");
            var value = this.textBox2.Text;
            var returnedData = db.Table<Shorts>()
                                 .Where(result => result.ShortCutName == value)
                                 .FirstOrDefault();

            if (returnedData == null)
            {
                label2.ForeColor = System.Drawing.Color.Red;
                label2.Text = "That shortcut does not exist";
                db.Close();
            }
            else
            {
                string clipboardContent = returnedData.ShortCutText;
                Clipboard.SetText(clipboardContent);
                label2.ForeColor = System.Drawing.Color.Green;
                label2.Text = "Shortcut successfully copied";

                // Increment the TimesUsed count
                returnedData.TimesUsed += 1;

                // Update the database
                db.Update(returnedData);
                db.Close();
            }
        }

        private void textBox2_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConfirmFindButton.PerformClick();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Empty event handler, can be left as is.
        }
    }
}
