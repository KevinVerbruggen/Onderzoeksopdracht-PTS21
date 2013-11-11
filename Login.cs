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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbGebruikersnaam.TextLength > 0 && tbWachtwoord.TextLength > 0)
            {
                DataRow inlog = DBconnect.Instantie.SingleSelect("account", "*", "gebruikersnaam = '" + tbGebruikersnaam.Text + "' AND wachtwoord = '" + tbWachtwoord.Text + "'");

                if (inlog != null)
                {
                    if (inlog["soort"].ToString() == "geblokkeerd")
                    {
                        MessageBox.Show("Uw account is geblokkeerd.");
                    }
                    else
                    {
                        //Haal gegevens uit DataRow om localUser te vullen
                        bool soortAccount = (inlog["soort"].ToString() == "admin") ? true : false;
                        mainclass.localUser = new User((int)inlog["BezoekerID"], soortAccount);
                        mainclass.localUser.Admin = (inlog["soort"].ToString() == "admin") ? true : false;


                        FileShareForm f = new FileShareForm();
                        f.UserName = inlog["gebruikersnaam"].ToString();
                        f.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Onjuiste gebruikersnaam en/of wachtwoord\nProbeer het opnieuw");
                }
            }
            else
            {
                MessageBox.Show("Voer uw gebruikersnaam of wachtwoord in");
            }

            
        }
    }
}
