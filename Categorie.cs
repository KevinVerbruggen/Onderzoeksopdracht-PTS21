using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileShare
{
    class Categorie
    {
        //Variables
        private int categorieID;
        private string naam;
        private int? parentID;
        private List<File> files = new List<File>();

        //Properties
        public int CategorieID
        {
            set { categorieID = value; }
            get { return categorieID; }
        }

        public string Naam
        {
            set { naam = value; }
            get { return naam; }
        }

        public int? ParentID
        {
            set { parentID = value; }
            get { return parentID; }
        }

        public List<File> Files
        {
            set { files = value; }
            get { return files; }
        }

        //Constructors
        public Categorie(string naam)
        {
            this.naam = naam;
            this.parentID = null;
        }

        public Categorie(string naam, int parentID)
        {
            this.naam = naam;
            this.parentID = parentID;
        }

        public Categorie(int categorieID, string naam)
        {
            this.categorieID = categorieID;
            this.naam = naam;
        }
        public Categorie(int categorieID, string naam, int? parentID)
        {
            this.categorieID = categorieID;
            this.naam = naam;
            this.parentID = parentID;
        }

        //Functies
        public override string ToString()
        {
            string hoofdklassenaam = null;
            if (this.parentID != null)
            {
                hoofdklassenaam = VindHoofdKlasseNaam(this.parentID);
                return String.Format("{0}. {1} ({2})", categorieID, naam, hoofdklassenaam);
            }
            else
            {
                return String.Format("{0}. {1}", categorieID, naam);
            }
        }

        public string VindHoofdKlasseNaam(int? parentID)
        {
            foreach (Categorie c in mainclass.AlleCategorieen)
            {
                if (c.CategorieID == parentID)
                {
                    return c.Naam;
                }
            }
            return null;
        }
    }
}
