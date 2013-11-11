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
    public partial class FormBestandZichtbaarheid : Form
    {
        string bestandsNaam;
        string uploadBestandLocatie;
        List<int> categorien;
        List<int> checkedUsers;

        public FormBestandZichtbaarheid(string bestandsNaam, string uploadBestandLocatie, List<int> categorien)
        {
            InitializeComponent();
            checkedListBoxZichtbaarheid.Items.Add(mainclass.localUser.BezoekerID, true);
            foreach (User bezoeker in mainclass.AlleGebruikers)
            {
                checkedListBoxZichtbaarheid.Items.Add(bezoeker.Gebruikersnaam, false);
            }
            this.bestandsNaam = bestandsNaam;
            this.uploadBestandLocatie = uploadBestandLocatie;
            this.categorien = categorien;
        }

        private void vulListUsers()
        {
            checkedUsers.Clear();
            foreach (int indexChecked in checkedListBoxZichtbaarheid.CheckedIndices)
            {
                checkedUsers.Add(indexChecked);
            }
        }

        private void checkedListBoxZichtbaarheid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            vulListUsers();
            if (checkedListBoxZichtbaarheid.CheckedItems.Count > 0)
            {
                mainclass.localUser.UploadBestand(bestandsNaam, uploadBestandLocatie, categorien, checkedUsers);
                MessageBox.Show("Uw file is met succes geupload naar de server");
                this.Close();
            }
            else
            {
                MessageBox.Show("Je hebt geen gebruikers geselecteerd.");
            }
        }

    }
}
