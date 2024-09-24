using System;
using System.Windows.Forms;
using ShortcutGUI.models;
using SQLite;

namespace ShortcutGUI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            var getConfig = new SQLiteConnection("./shortcut.db");
            var config = getConfig.Table<Config>().FirstOrDefault();
            int value = config.MostUsedTreshold;

            ListView listView = this.listView1;
            listView.View = View.List;
            listView.ShowItemToolTips = true;

            using (SQLiteConnection db = new SQLiteConnection("./shortcut.db"))
            {

                var query = "SELECT * FROM shorts ORDER BY CAST(TimesUsed AS INTEGER) DESC LIMIT ?";
                var returnedData = db.Query<Shorts>(query, value);

                foreach (var data in returnedData)
                {
                    ListViewItem item = new ListViewItem($"{data.ShortCutName} ({data.TimesUsed})");

                    item.ToolTipText = data.ShortCutText;

                    listView.Items.Add(item);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            var mainMenu = new Form1();
            mainMenu.Show();
        }
    }
}
