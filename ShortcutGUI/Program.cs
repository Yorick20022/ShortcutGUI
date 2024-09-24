using System;
using System.Drawing;
using System.Windows.Forms;
using ShortcutGUI.models;
using SQLite;

namespace ShortcutGUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SQLiteConnection db = new SQLiteConnection("./shortcut.db");
            db.CreateTable<Shorts>();
            db.CreateTable<Config>(); // Create the table
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (NotifyIcon icon = new NotifyIcon())
            {
                icon.Icon = Icon.ExtractAssociatedIcon("images/ShortcutGUI.ico");
                icon.ContextMenu = new ContextMenu(new MenuItem[] {
            });
                icon.Click += (sender, args) => { new Form1().Show(); };
                icon.Visible = true;

                Application.Run();
                icon.Visible = false;
            }
        }
    }
}
