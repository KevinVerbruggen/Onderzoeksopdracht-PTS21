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
    public partial class CategorienForm : Form
    {
        string uploadBestandLocatie;
        string bestandsNaam;
        private List<int> checkedCategorien = new List<int>();

        public CategorienForm(string bestandsNaam, string uploadBestandLocatie)
        {
            InitializeComponent();
            this.bestandsNaam = bestandsNaam;
            this.uploadBestandLocatie = uploadBestandLocatie;
            foreach (Categorie categorie in mainclass.AlleCategorieen)
            {
                checkedListBoxCategorien.Items.Add(categorie.Naam, false);
            }
        }

        private void vulListCategorien()
        {
            if (checkedCategorien != null)
            {
                checkedCategorien.Clear();
            }
            if (checkedListBoxCategorien.CheckedIndices != null)
            {
                foreach (int indexChecked in checkedListBoxCategorien.CheckedIndices)
                {
                    checkedCategorien.Add(indexChecked);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (checkedListBoxCategorien.CheckedItems.Count == 1)
            {
                FormBestandZichtbaarheid zichtbaarheidsForm = new FormBestandZichtbaarheid(bestandsNaam, uploadBestandLocatie, checkedCategorien);
                this.Close();
            }
            else if (checkedListBoxCategorien.CheckedItems.Count == 0)
            {
                MessageBox.Show("Je hebt geen categoriën geselecteerd.");
            }
            else
            {
                DialogResult doorgaanYN = MessageBox.Show("Je hebt meer dan 1 categorie geselecteerd. Weet je zeker dat je wilt doorgaan?", "Weet je het zeker?", MessageBoxButtons.YesNo);
                if (doorgaanYN == DialogResult.Yes)
                {
                    FormBestandZichtbaarheid zichtbaarheidsForm = new FormBestandZichtbaarheid(bestandsNaam, uploadBestandLocatie.ToString(), checkedCategorien);
                    this.Close();
                }
            }

        }

        private void buttonAnnuleren_Click(object sender, EventArgs e)
        {
            return;
        }

        private void buttonNieuweCategorie_Click(object sender, EventArgs e)
        {
            vulListCategorien();
            if (this.checkedCategorien != null)
            {
                if (this.checkedCategorien.Count == 1)
                {
                    //mainclass.localUser.CreeerCategorie(this.textBoxNieuweCategorie.Text, this.checkedCategorien[0]);
                }
                else if (this.checkedCategorien.Count == 0)
                {
                    //mainclass.localUser.CreeerCategorie(this.textBoxNieuweCategorie.Text);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Je hebt meerdere categorieën geselecteerd. Als je doorgaat, zal de nieuwe categorie geen hoofdcategorie hebben.", "Let op!", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.Yes)
                    {
                        //mainclass.localUser.CreeerCategorie(this.textBoxNieuweCategorie.Text);
                        vulListCategorien();
                    }
                    else
                    {
                    }
                }
            }
            else
            {
                //mainclass.localUser.CreeerCategorie(this.textBoxNieuweCategorie.Text);
            }

        }

        private void textBoxNieuweCategorie_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxCategorien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
