namespace FileShare
{
    partial class Login
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbGebruikersnaam = new System.Windows.Forms.TextBox();
            this.tbWachtwoord = new System.Windows.Forms.TextBox();
            this.lbGebruikersnaam = new System.Windows.Forms.Label();
            this.lbWachtwoord = new System.Windows.Forms.Label();
            this.tbDomain = new System.Windows.Forms.TextBox();
            this.lbDomain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(182, 112);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbGebruikersnaam
            // 
            this.tbGebruikersnaam.Location = new System.Drawing.Point(119, 33);
            this.tbGebruikersnaam.Name = "tbGebruikersnaam";
            this.tbGebruikersnaam.Size = new System.Drawing.Size(138, 20);
            this.tbGebruikersnaam.TabIndex = 1;
            // 
            // tbWachtwoord
            // 
            this.tbWachtwoord.Location = new System.Drawing.Point(119, 59);
            this.tbWachtwoord.Name = "tbWachtwoord";
            this.tbWachtwoord.PasswordChar = '*';
            this.tbWachtwoord.Size = new System.Drawing.Size(138, 20);
            this.tbWachtwoord.TabIndex = 2;
            // 
            // lbGebruikersnaam
            // 
            this.lbGebruikersnaam.AutoSize = true;
            this.lbGebruikersnaam.Location = new System.Drawing.Point(13, 33);
            this.lbGebruikersnaam.Name = "lbGebruikersnaam";
            this.lbGebruikersnaam.Size = new System.Drawing.Size(84, 13);
            this.lbGebruikersnaam.TabIndex = 3;
            this.lbGebruikersnaam.Text = "Gebruikersnaam";
            // 
            // lbWachtwoord
            // 
            this.lbWachtwoord.AutoSize = true;
            this.lbWachtwoord.Location = new System.Drawing.Point(13, 65);
            this.lbWachtwoord.Name = "lbWachtwoord";
            this.lbWachtwoord.Size = new System.Drawing.Size(68, 13);
            this.lbWachtwoord.TabIndex = 4;
            this.lbWachtwoord.Text = "Wachtwoord";
            // 
            // tbDomain
            // 
            this.tbDomain.Location = new System.Drawing.Point(119, 85);
            this.tbDomain.Name = "tbDomain";
            this.tbDomain.PasswordChar = '*';
            this.tbDomain.Size = new System.Drawing.Size(138, 20);
            this.tbDomain.TabIndex = 5;
            // 
            // lbDomain
            // 
            this.lbDomain.AutoSize = true;
            this.lbDomain.Location = new System.Drawing.Point(13, 88);
            this.lbDomain.Name = "lbDomain";
            this.lbDomain.Size = new System.Drawing.Size(43, 13);
            this.lbDomain.TabIndex = 6;
            this.lbDomain.Text = "Domein";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 147);
            this.Controls.Add(this.lbDomain);
            this.Controls.Add(this.tbDomain);
            this.Controls.Add(this.lbWachtwoord);
            this.Controls.Add(this.lbGebruikersnaam);
            this.Controls.Add(this.tbWachtwoord);
            this.Controls.Add(this.tbGebruikersnaam);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbGebruikersnaam;
        private System.Windows.Forms.TextBox tbWachtwoord;
        private System.Windows.Forms.Label lbGebruikersnaam;
        private System.Windows.Forms.Label lbWachtwoord;
        private System.Windows.Forms.TextBox tbDomain;
        private System.Windows.Forms.Label lbDomain;
    }
}