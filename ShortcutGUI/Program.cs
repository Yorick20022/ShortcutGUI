using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ShortcutGUI.models;
using SQLite;

namespace ShortcutGUI
{
    internal static class Program
    {
        // Mutex to ensure single instance
        private static Mutex mutex = null;

        [STAThread]
        static void Main()
        {

            // Setup SQLite database
            SQLiteConnection db = new SQLiteConnection("./shortcut.db");
            db.CreateTable<Shorts>();
            db.CreateTable<Config>(); // Create the table

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // NotifyIcon setup
            using (NotifyIcon icon = new NotifyIcon())
            {
                icon.Icon = Icon.ExtractAssociatedIcon("images/ShortcutGUI.ico");
                icon.Visible = true;

                // Create icon in system tray
                ContextMenu contextMenu = new ContextMenu();
                contextMenu.MenuItems.Add("Open", (sender, e) => { new Form1().Show(); });
                contextMenu.MenuItems.Add("Exit", (sender, e) => { Application.Exit(); });

                icon.ContextMenu = contextMenu;

                icon.Click += (sender, args) =>
                {
                    if (((MouseEventArgs)args).Button == MouseButtons.Left)
                    {
                        new Form1().Show();
                    }
                };

                // Application event loop
                Application.Run();
                icon.Visible = false;
            }
        }
    }
}
