using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;

namespace FileShare
{
    class mainclass
    {
        public static string servernaam = "localhost";
        public static double flagwaarde = 0.2;

        public static List<File> AlleFiles = new List<File>();
        public static List<File> EigenBestanden = new List<File>();
        public static List<File> GeFlagteBestanden = new List<File>();
        public static List<User> AlleGebruikers = new List<User>();
        public static List<Categorie> AlleCategorieen = new List<Categorie>();
        public static DBconnect connectie = DBconnect.Instantie;
        public static Computer myComputer = new Computer();
        public static User localUser;
        public static List<File> GeselecteerdeCategorieBestanden = new List<File>();


        public static void InitialiseerApp()
        {
            //Hier worden alle datatables aangemaakt.
            DataTable bestandenTabel;
            DataTable eigenBestandenTabel;
            DataTable geFlagteBestandenTabel;
            DataTable alleGebruikersTabel;
            DataTable categorienTabel;

            //Tabellen leeggooien
            AlleFiles.Clear();
            EigenBestanden.Clear();
            GeFlagteBestanden.Clear();
            AlleGebruikers.Clear();
            AlleCategorieen.Clear();

            //Hier worden alle gegevens opgehaald uit de database.
            if (localUser.Admin == false)
            {
                bestandenTabel = connectie.SelectMultiple("Bestand", "*", "BestandID IN (SELECT BestandID FROM Bestandzichtbaarheid WHERE BezoekerID = " + localUser.BezoekerID + ")");
            }
            else
            {
                bestandenTabel = connectie.SelectMultiple("Bestand", "*");
            }
            eigenBestandenTabel = connectie.SelectMultiple("Bestand", "*", "BezoekerID = " + localUser.BezoekerID);
            geFlagteBestandenTabel = connectie.SelectMultiple("Bestand", "*", "BestandID IN (SELECT DISTINCT(BestandID) FROM Flag)");
            alleGebruikersTabel = connectie.SelectMultiple("account", "*");
            categorienTabel = connectie.SelectMultiple("Categorie", "*");

            //Hier worden de gegevens omgezet naar een leesbaar formaat.
            foreach (DataRow row in bestandenTabel.Rows)
            {
                AlleFiles.Add(new File(Convert.ToInt32(row["BestandID"]), Convert.ToString(row["Naam"]), Convert.ToInt32(row["BezoekerID"]), Convert.ToString(row["Locatie"])));
            }
            foreach (DataRow row in eigenBestandenTabel.Rows)
            {
                EigenBestanden.Add(new File(Convert.ToInt32(row["BestandID"]), Convert.ToString(row["Naam"]), Convert.ToInt32(row["BezoekerID"]), Convert.ToString(row["Locatie"])));
            }
            foreach (DataRow row in geFlagteBestandenTabel.Rows)
            {
                GeFlagteBestanden.Add(new File(Convert.ToInt32(row["BestandID"]), Convert.ToString(row["Naam"]), Convert.ToInt32(row["BezoekerID"]), Convert.ToString(row["Locatie"])));
            }
            foreach (DataRow row in alleGebruikersTabel.Rows)
            {
                AlleGebruikers.Add(new User(Int32.Parse(row["BezoekerID"].ToString()), row["Gebruikersnaam"].ToString(), row["Wachtwoord"].ToString(), row["soort"].ToString()));
            }

            foreach (DataRow row in categorienTabel.Rows)
            {
                if (row["ParentID"].Equals(DBNull.Value))
                {
                    AlleCategorieen.Add(new Categorie(Convert.ToInt32(row["CategorieID"]), Convert.ToString(row["Naam"])));
                }
                else
                {
                    AlleCategorieen.Add(new Categorie(Convert.ToInt32(row["CategorieID"]), Convert.ToString(row["Naam"]), Convert.ToInt32(row["ParentID"])));
                }
            }
        }

        public static void VulLijstGeselecteerdeCategorieBestanden(int categorie)
        {
            DataTable geselecteerdeCategorieBestandenTabel;
            geselecteerdeCategorieBestandenTabel = connectie.SelectMultiple("Bestand", "*", "BestandID IN (SELECT BestandID FROM Bestand_Categorie WHERE CategorieID = " + categorie + ")");
            GeselecteerdeCategorieBestanden.Clear();
            foreach (DataRow row in geselecteerdeCategorieBestandenTabel.Rows)
            {
                GeselecteerdeCategorieBestanden.Add(new File(Convert.ToInt32(row["BestandID"]), Convert.ToString(row["Naam"]), Convert.ToInt32(row["BezoekerID"]), Convert.ToString(row["Locatie"])));
            }
        }

        public static bool StringToBool(string str) 
        {
            if (str.Equals('Y')) 
            {
                return true;
            }
            else if (str.Equals('N'))
            {
                return false;
            }
            else {
                return false;
            }
        }

        public static File GetFileByID(int bestandID)
        {
            List<File> shortList = AlleFiles.Where(o => o.BestandID == bestandID).ToList();

            if (shortList.Count > 0)
            {
                return shortList[0];
            }
            else
            {
                return null;
            }
        }

        public static int GetMaxBestandID()
        {
            return Convert.ToInt32(connectie.SingleSelect("Bestanden", "MAX(BestandID)", ""));
        }

        public static void VerwijderBestand(int bestandID, int userID){
            List<File> shortList = AlleFiles.Where(o => o.BestandID == bestandID).ToList();
            File f = shortList[0];
            if (shortList.Count > 0 && (localUser.Admin == true || localUser.BezoekerID == Convert.ToInt32(connectie.SingleSelect("Bestand", "bezoekerID", "bestandID = " + bestandID))))
            {
                AutoVerwijderBestand(bestandID);
            }
            else
            {
                MessageBox.Show("Er is iets misgegaan. Het bestand kan niet verwijderd worden.");
            }
        }

        public static void AutoVerwijderBestand(int bestandID) 
        {
            myComputer.FileSystem.DeleteFile(@"\\" + servernaam + @"\" + connectie.SingleSelect("Bestand", "locatie", "BestandID = " + bestandID), Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently);

            connectie.Delete("BestandZichtbaarheid", "BestandID = " + bestandID);
            connectie.Delete("Vote", "BestandID = " + bestandID);
            connectie.Delete("Flag", "BestandID = " + bestandID);
            connectie.Delete("Bestand_Categorie", "BestandID = " + bestandID);

            /*Database-connectie mogelijk vervangen door locatie in 'AlleBestanden'-lijst*/
            connectie.Delete("Bestand", "BestandID = " + bestandID);

        }

        //De functie om een categorie te verwijderen.
        public static void VerwijderCategorie(List<int> categorieIDs)
        {
            if (localUser.Admin == true) //Indien de gebruiker de admin is,
            {
                List<int> BestandIDs = new List<int>();
                //alle bestanden die alleen in deze categorie zitten en de categorie zelf verwijderen.
                DataTable BestandIDsDB = connectie.SelectMultiple("Bestand_categorie", "BestandID", "CategorieID = " + categorieIDs + "HAVING COUNT(*) < 2 GROUP BY BestandID");
                foreach (DataRow row in BestandIDsDB.Rows)
                {
                    BestandIDs.Add(Convert.ToInt32(row["BestandID"]));
                }

                for (int i = 0; i < BestandIDs.Count(); i++)
                {
                    mainclass.VerwijderBestand(BestandIDs[i], localUser.BezoekerID);
                }

                foreach (int i in categorieIDs)
                {
                    connectie.Delete("categorie", "categorieID=" + categorieIDs[i]);
                }
            }
            else //Voor elke andere gebruiker,
            { //deze opdracht negeren
                return;
            }
        }

        public static void UploadBestand(string uploadBestandLocatie, List<int> categorieIDs, List<int> bestandZichtbaarheid)
        {
            int bestandID = GetMaxBestandID() + 1;
            string bestandsnaam = System.IO.Path.GetFileName(uploadBestandLocatie);
            myComputer.FileSystem.CopyFile(uploadBestandLocatie, @"\\FILESHARE-SERVER\" + bestandID);
            connectie.Insert("Bestand", bestandsnaam + ", " + bestandID.ToString() + ", " + localUser.BezoekerID, "Naam, Locatie, bezoekerID");
            AlleFiles.Add(new File(Convert.ToInt32(AlleFiles.Count), Convert.ToString(Path.GetFileName(uploadBestandLocatie)), Convert.ToInt32(localUser.BezoekerID), Convert.ToString(uploadBestandLocatie)));
            foreach (int i in categorieIDs)
            {
                connectie.Insert("BestandCategorie", bestandID + ", " + i, "BestandID, CategorieID");
            }
            foreach (int i in bestandZichtbaarheid)
            {
                connectie.Insert("BestandZichtbaarheid", bestandID + ", " + i, "BestandID, bezoekerID");
            }
        }

        public static void DownloadBestand(List<int> bestandID)
        {
            foreach (int i in bestandID)
            {
                myComputer.FileSystem.CopyFile(@"\\FILESHARE-SERVER\" + i, @"%USERPROFILE%\Downloads\" + Convert.ToInt32(connectie.SingleSelect("Bestand", "naam", "bestandID = " + bestandID)));
            }
        }
    }
}
