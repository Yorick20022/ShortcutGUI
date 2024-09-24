namespace ShortcutGUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.FindShortcut = new System.Windows.Forms.Button();
            this.AddNew = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.MostUsedButton = new System.Windows.Forms.Button();
            this.SettingsIcon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "ShortcutGUI";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FindShortcut
            // 
            this.FindShortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindShortcut.Location = new System.Drawing.Point(12, 118);
            this.FindShortcut.Name = "FindShortcut";
            this.FindShortcut.Size = new System.Drawing.Size(179, 68);
            this.FindShortcut.TabIndex = 0;
            this.FindShortcut.Text = "Find shortcut";
            this.FindShortcut.UseVisualStyleBackColor = true;
            this.FindShortcut.Click += new System.EventHandler(this.FindShortcut_Click);
            // 
            // AddNew
            // 
            this.AddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNew.Location = new System.Drawing.Point(244, 118);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(179, 68);
            this.AddNew.TabIndex = 7;
            this.AddNew.Text = "Add new";
            this.AddNew.UseVisualStyleBackColor = true;
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            // 
            // MostUsedButton
            // 
            this.MostUsedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostUsedButton.Location = new System.Drawing.Point(128, 215);
            this.MostUsedButton.Name = "MostUsedButton";
            this.MostUsedButton.Size = new System.Drawing.Size(179, 68);
            this.MostUsedButton.TabIndex = 8;
            this.MostUsedButton.Text = "Most used";
            this.MostUsedButton.UseVisualStyleBackColor = true;
            this.MostUsedButton.Click += new System.EventHandler(this.MostUsed_Click);
            // 
            // SettingsIcon
            // 
            this.SettingsIcon.AutoSize = true;
            this.SettingsIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsIcon.Location = new System.Drawing.Point(369, 314);
            this.SettingsIcon.Name = "SettingsIcon";
            this.SettingsIcon.Size = new System.Drawing.Size(54, 37);
            this.SettingsIcon.TabIndex = 10;
            this.SettingsIcon.Text = "⚒";
            this.SettingsIcon.Click += new System.EventHandler(this.SettingsIcon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 360);
            this.Controls.Add(this.SettingsIcon);
            this.Controls.Add(this.MostUsedButton);
            this.Controls.Add(this.AddNew);
            this.Controls.Add(this.FindShortcut);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShortcutGUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button FindShortcut;
        private System.Windows.Forms.Button AddNew;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private System.Windows.Forms.Button MostUsedButton;
        private System.Windows.Forms.Label SettingsIcon;
    }
}

