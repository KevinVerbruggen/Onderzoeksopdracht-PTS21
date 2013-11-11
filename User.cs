using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace FileShare
{
    class User //Een gebruiker/bezoeker
    {
        DBconnect connectie = DBconnect.Instantie;
        //Benodigde variabelen.
        private int bezoekerID;
        private string gebruikersnaam;
        private string wachtwoord;
        private string soort;
        private Boolean admin;

        //Properties vaststellen
        public int BezoekerID
        {
            set { bezoekerID = value; }
            get { return bezoekerID; }
        }

        public Boolean Admin
        {
            set { admin = value; }
            get { return admin; }
        }

        public string Gebruikersnaam
        {
            set { gebruikersnaam = value; }
            get { return gebruikersnaam; }
        }


        //De constructor. Met deze functie worden de variabelen met de waardes van een huurder uit de database gevuld. 
        public User(int bezoekerID, Boolean admin)
        {
            this.bezoekerID = bezoekerID;
            this.admin = admin;
        }

        public User(int bezoekerID, string gebruikersnaam, string wachtwoord, string soort)
        {
            this.bezoekerID = bezoekerID;
            this.gebruikersnaam = gebruikersnaam;
            this.wachtwoord = wachtwoord;
            this.soort = soort;
        }




        //De functies om een gebruiker een nieuwe categorie te laten aanmaken.
        public void CreeerCategorie(string naam, int parentID)
        {
            mainclass.AlleCategorieen.Add(new Categorie(naam, parentID));
            connectie.Insert("Categorie", naam + ", " + parentID, "Naam, ParentID");
        }

        public void CreeerCategorie(string naam)
        {
            mainclass.AlleCategorieen.Add(new Categorie(naam));
            connectie.Insert("Categorie", "'" + naam + "'", "Naam");
        }

        //De functie om een stem te geven aan een bestand.
        public void Vote(Boolean upvote, int bestandID)
        {
            string sUpvote = "Y";
            if (!upvote)
            {
                sUpvote = "N";
            }

            connectie.Delete("vote", "BezoekerID = '" + mainclass.GetFileByID(bestandID).BezoekerID + "' AND BestandID = '" + bestandID + "'");
            connectie.Insert("vote", String.Format("{0}, {1}, '{2}'", bestandID, mainclass.GetFileByID(bestandID).BezoekerID, sUpvote), "BestandID, BezoekerID, Upvote");
        }

        public void Rapporteren(List<int> bestandIDs)
        {
            foreach (int i in bestandIDs)
            {
                connectie.Insert("Flag", bestandIDs[i] + ", " + bezoekerID, "bestandID, bezoekerID");
                if (mainclass.GeFlagteBestanden.Count() > mainclass.flagwaarde * mainclass.AlleGebruikers.Count())
                {
                    connectie.Delete("BestandZichtbaarheid", "BestandID = " + i);
                }
                //mainclass.GeFlagteBestanden.Add();
            }
            mainclass.InitialiseerApp();
        }

        public override string ToString()
        {
            return String.Format("ID: {0}, Naam: {1}, Wachtwoord: {2}, Soort account: {3} ", bezoekerID, gebruikersnaam, wachtwoord, soort);
        }

        public void UploadBestand(string bestandsNaam, string uploadBestandLocatie, List<int> categorieIDs, List<int> bestandZichtbaarheid)
        {
            int bestandID = mainclass.GetMaxBestandID() + 1;
            string bestandsnaam = System.IO.Path.GetFileName(uploadBestandLocatie);
            mainclass.myComputer.FileSystem.CopyFile(uploadBestandLocatie, @"\\FILESHARE-SERVER\" + bestandID);
            mainclass.connectie.Insert("Bestand", bestandsnaam + ", " + bestandID.ToString() + ", " + bezoekerID, "Naam, Locatie, bezoekerID");
            mainclass.AlleFiles.Add(new File(Convert.ToInt32(mainclass.AlleFiles.Count), Convert.ToString(bestandsNaam), Convert.ToInt32(BezoekerID), Convert.ToString(uploadBestandLocatie)));
            foreach (int i in categorieIDs)
            {
                mainclass.connectie.Insert("BestandCategorie", bestandID + ", " + i, "BestandID, CategorieID");
            }
            foreach (int i in bestandZichtbaarheid)
            {
                mainclass.connectie.Insert("BestandZichtbaarheid", bestandID + ", " + i, "BestandID, bezoekerID");
            }
        }

        public void Blokkeer(int blockID)
        {
            if (this.admin == true)
            {
                if (Convert.ToString(mainclass.connectie.SingleSelect("Account", "soort", "BezoekersID = " + blockID)) == "geblokkeerd")
                {//als account geblokkeerd is, unblock hem.
                    mainclass.connectie.Update("Account", "soort='normaal'", "bezoekerID = " + blockID);
                }
                else
                {//als account niet geblokkeerd is, blokkeer hem.
                    mainclass.connectie.Update("Account", "soort='geblokkeerd'", "bezoekerID = " + blockID);
                }
            }
        }
    }
}
