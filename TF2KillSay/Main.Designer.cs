namespace TF2KillSay
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MainMenu = new System.Windows.Forms.TabControl();
            this.MainMenuTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.KillSayText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.SetPlayerNameBtn = new System.Windows.Forms.Button();
            this.PlayerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SetTF2DirBtn = new System.Windows.Forms.Button();
            this.TF2Directory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            this.MainMenuTab.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Controls.Add(this.MainMenuTab);
            this.MainMenu.Controls.Add(this.SettingsTab);
            this.MainMenu.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.Location = new System.Drawing.Point(12, 12);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.SelectedIndex = 0;
            this.MainMenu.Size = new System.Drawing.Size(776, 408);
            this.MainMenu.TabIndex = 0;
            // 
            // MainMenuTab
            // 
            this.MainMenuTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.MainMenuTab.Controls.Add(this.label3);
            this.MainMenuTab.Controls.Add(this.KillSayText);
            this.MainMenuTab.Controls.Add(this.label2);
            this.MainMenuTab.Location = new System.Drawing.Point(4, 36);
            this.MainMenuTab.Name = "MainMenuTab";
            this.MainMenuTab.Padding = new System.Windows.Forms.Padding(3);
            this.MainMenuTab.Size = new System.Drawing.Size(768, 368);
            this.MainMenuTab.TabIndex = 0;
            this.MainMenuTab.Text = "Home";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(455, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Put %v where you want the name of your victim to be.";
            // 
            // KillSayText
            // 
            this.KillSayText.Location = new System.Drawing.Point(6, 42);
            this.KillSayText.Multiline = true;
            this.KillSayText.Name = "KillSayText";
            this.KillSayText.Size = new System.Drawing.Size(756, 257);
            this.KillSayText.TabIndex = 2;
            this.KillSayText.Text = "the sewer pig";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Killsay Text:";
            // 
            // SettingsTab
            // 
            this.SettingsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.SettingsTab.Controls.Add(this.SetPlayerNameBtn);
            this.SettingsTab.Controls.Add(this.PlayerName);
            this.SettingsTab.Controls.Add(this.label5);
            this.SettingsTab.Controls.Add(this.SetTF2DirBtn);
            this.SettingsTab.Controls.Add(this.TF2Directory);
            this.SettingsTab.Controls.Add(this.label1);
            this.SettingsTab.Location = new System.Drawing.Point(4, 36);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTab.Size = new System.Drawing.Size(768, 368);
            this.SettingsTab.TabIndex = 1;
            this.SettingsTab.Text = "Settings";
            // 
            // SetPlayerNameBtn
            // 
            this.SetPlayerNameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.SetPlayerNameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetPlayerNameBtn.ForeColor = System.Drawing.Color.White;
            this.SetPlayerNameBtn.Location = new System.Drawing.Point(442, 53);
            this.SetPlayerNameBtn.Name = "SetPlayerNameBtn";
            this.SetPlayerNameBtn.Size = new System.Drawing.Size(115, 41);
            this.SetPlayerNameBtn.TabIndex = 8;
            this.SetPlayerNameBtn.Text = "Set";
            this.SetPlayerNameBtn.UseVisualStyleBackColor = false;
            this.SetPlayerNameBtn.Click += new System.EventHandler(this.SetPlayerNameBtn_Click);
            // 
            // PlayerName
            // 
            this.PlayerName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerName.Location = new System.Drawing.Point(147, 59);
            this.PlayerName.MaxLength = 32;
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(289, 32);
            this.PlayerName.TabIndex = 7;
            this.PlayerName.Text = "the sewer pig";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Your name:";
            // 
            // SetTF2DirBtn
            // 
            this.SetTF2DirBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.SetTF2DirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetTF2DirBtn.ForeColor = System.Drawing.Color.White;
            this.SetTF2DirBtn.Location = new System.Drawing.Point(647, 6);
            this.SetTF2DirBtn.Name = "SetTF2DirBtn";
            this.SetTF2DirBtn.Size = new System.Drawing.Size(115, 41);
            this.SetTF2DirBtn.TabIndex = 2;
            this.SetTF2DirBtn.Text = "Set";
            this.SetTF2DirBtn.UseVisualStyleBackColor = false;
            this.SetTF2DirBtn.Click += new System.EventHandler(this.SetTF2DirBtn_Click);
            // 
            // TF2Directory
            // 
            this.TF2Directory.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TF2Directory.Location = new System.Drawing.Point(175, 10);
            this.TF2Directory.Name = "TF2Directory";
            this.TF2Directory.Size = new System.Drawing.Size(466, 32);
            this.TF2Directory.TabIndex = 1;
            this.TF2Directory.Text = "D:\\SteamLibrary\\steamapps\\common\\Team Fortress 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "TF2 Directory:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(562, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Created by the sewer pig.";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TF2 KillSay";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenuTab.ResumeLayout(false);
            this.MainMenuTab.PerformLayout();
            this.SettingsTab.ResumeLayout(false);
            this.SettingsTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl MainMenu;
        private System.Windows.Forms.TabPage MainMenuTab;
        private System.Windows.Forms.TabPage SettingsTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SetTF2DirBtn;
        private System.Windows.Forms.TextBox TF2Directory;
        private System.Windows.Forms.TextBox KillSayText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SetPlayerNameBtn;
        private System.Windows.Forms.TextBox PlayerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

