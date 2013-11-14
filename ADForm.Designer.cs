namespace FileShare
{
    partial class ADForm
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
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGroupName = new System.Windows.Forms.TextBox();
            this.buttonAddUserToGroup = new System.Windows.Forms.Button();
            this.buttonDeleteUserFromGroup = new System.Windows.Forms.Button();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbDisplayName = new System.Windows.Forms.TextBox();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.buttonDeleteGroup = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUsers
            // 
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.Location = new System.Drawing.Point(13, 13);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(120, 121);
            this.lbUsers.TabIndex = 0;
            this.lbUsers.SelectedIndexChanged += new System.EventHandler(this.lbUsers_SelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(12, 173);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(56, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Zoeken";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(13, 147);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(119, 20);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.Text = "Zoek...";
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Accountnaam: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Volledige naam: ";
            // 
            // tbGroupName
            // 
            this.tbGroupName.Location = new System.Drawing.Point(142, 147);
            this.tbGroupName.Name = "tbGroupName";
            this.tbGroupName.Size = new System.Drawing.Size(183, 20);
            this.tbGroupName.TabIndex = 5;
            this.tbGroupName.Text = "Groepnaam";
            this.tbGroupName.TextChanged += new System.EventHandler(this.tbGroupName_TextChanged);
            // 
            // buttonAddUserToGroup
            // 
            this.buttonAddUserToGroup.Location = new System.Drawing.Point(142, 82);
            this.buttonAddUserToGroup.Name = "buttonAddUserToGroup";
            this.buttonAddUserToGroup.Size = new System.Drawing.Size(183, 23);
            this.buttonAddUserToGroup.TabIndex = 6;
            this.buttonAddUserToGroup.Text = "Voeg toe aan groep";
            this.buttonAddUserToGroup.UseVisualStyleBackColor = true;
            this.buttonAddUserToGroup.Click += new System.EventHandler(this.buttonAddUserToGroup_Click);
            // 
            // buttonDeleteUserFromGroup
            // 
            this.buttonDeleteUserFromGroup.Location = new System.Drawing.Point(142, 111);
            this.buttonDeleteUserFromGroup.Name = "buttonDeleteUserFromGroup";
            this.buttonDeleteUserFromGroup.Size = new System.Drawing.Size(183, 23);
            this.buttonDeleteUserFromGroup.TabIndex = 7;
            this.buttonDeleteUserFromGroup.Text = "Verwijder uit groep";
            this.buttonDeleteUserFromGroup.UseVisualStyleBackColor = true;
            this.buttonDeleteUserFromGroup.Click += new System.EventHandler(this.buttonDeleteUserFromGroup_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(225, 10);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(100, 20);
            this.tbUserName.TabIndex = 9;
            this.tbUserName.TextChanged += new System.EventHandler(this.tbUserName_TextChanged);
            // 
            // tbDisplayName
            // 
            this.tbDisplayName.Location = new System.Drawing.Point(225, 32);
            this.tbDisplayName.Name = "tbDisplayName";
            this.tbDisplayName.Size = new System.Drawing.Size(100, 20);
            this.tbDisplayName.TabIndex = 10;
            this.tbDisplayName.TextChanged += new System.EventHandler(this.tbDisplayName_TextChanged);
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.Location = new System.Drawing.Point(331, 53);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(85, 23);
            this.buttonEditUser.TabIndex = 11;
            this.buttonEditUser.Text = "Aanpassen";
            this.buttonEditUser.UseVisualStyleBackColor = true;
            this.buttonEditUser.Click += new System.EventHandler(this.buttonEditUser_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(331, 8);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(85, 23);
            this.buttonAddUser.TabIndex = 12;
            this.buttonAddUser.Text = "Toevoegen";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(225, 55);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 13;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Wachtwoord:";
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.Location = new System.Drawing.Point(142, 173);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(90, 23);
            this.buttonAddGroup.TabIndex = 15;
            this.buttonAddGroup.Text = "Toevoegen";
            this.buttonAddGroup.UseVisualStyleBackColor = true;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // buttonDeleteGroup
            // 
            this.buttonDeleteGroup.Location = new System.Drawing.Point(238, 173);
            this.buttonDeleteGroup.Name = "buttonDeleteGroup";
            this.buttonDeleteGroup.Size = new System.Drawing.Size(87, 23);
            this.buttonDeleteGroup.TabIndex = 17;
            this.buttonDeleteGroup.Text = "Verwijderen";
            this.buttonDeleteGroup.UseVisualStyleBackColor = true;
            this.buttonDeleteGroup.Click += new System.EventHandler(this.buttonDeleteGroup_Click);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(331, 30);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(85, 23);
            this.buttonDeleteUser.TabIndex = 18;
            this.buttonDeleteUser.Text = "Verwijderen";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // ADForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 202);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.buttonDeleteGroup);
            this.Controls.Add(this.buttonAddGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.buttonEditUser);
            this.Controls.Add(this.tbDisplayName);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.buttonDeleteUserFromGroup);
            this.Controls.Add(this.buttonAddUserToGroup);
            this.Controls.Add(this.tbGroupName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.lbUsers);
            this.Name = "ADForm";
            this.Text = "ADForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbGroupName;
        private System.Windows.Forms.Button buttonAddUserToGroup;
        private System.Windows.Forms.Button buttonDeleteUserFromGroup;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbDisplayName;
        private System.Windows.Forms.Button buttonEditUser;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.Button buttonDeleteGroup;
        private System.Windows.Forms.Button buttonDeleteUser;

    }
}