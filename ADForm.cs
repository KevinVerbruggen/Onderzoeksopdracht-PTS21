using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileShare
{
    public partial class ADForm : Form
    {
        public ADForm()
        {
            InitializeComponent();
        }

        private void lbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

            tbUserName.Text = ActiveDirectory.LoadUser(lbUsers.SelectedItem.UserName);
            tbDisplayName.Text = ActiveDirectory.LoadUser(lbUsers.SelectedItem.username).Properties["displayName"];
            tbPassword.Text = ActiveDirectory.LoadUser(lbUsers.SelectedItem.username).Properties["password"];
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ActiveDirectory.FindUser(tbSearch.Text);
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDisplayName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddUserToGroup_Click(object sender, EventArgs e)
        {
            ActiveDirectory.AddToGroup(tbUserName.Text, tbGroupName.Text);
        }

        private void buttonDeleteUserFromGroup_Click(object sender, EventArgs e)
        {
            ActiveDirectory.RemoveUserFromGroup(tbUserName.Text, tbGroupName.Text);
        }

        private void tbGroupName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            ActiveDirectory.Create("", tbGroupName.Text);
        }

        private void buttonDeleteGroup_Click(object sender, EventArgs e)
        {
            ActiveDirectory.Delete("", tbGroupName.Text);
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text != null && tbDisplayName.Text != null && tbPassword.Text != null) 
            {
                ActiveDirectory.CreateUserAccount(tbUserName.Text, tbUserName.Text, tbPassword.Text);
            }

        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            ActiveDirectory.DeleteUserAccount(lbUsers.SelectedItem.UserName, lbUsers.SelectedItem.UserName);

        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            ActiveDirectory.EditUserAccount(lbUsers.SelectedItem.username, lbUsers.SelectedItem.username, "name", tbUserName.Text);
            ActiveDirectory.EditUserAccount(lbUsers.SelectedItem.username, lbUsers.SelectedItem.username, "displayName", tbDisplayName.Text);
            ActiveDirectory.EditUserAccount(lbUsers.SelectedItem.username, lbUsers.SelectedItem.username, "password", tbPassword.Text);
        }
    }
}
