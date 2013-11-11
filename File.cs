using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileShare
{
    class File
    {
        //Alle variabelen.
        private int bestandID;
        private string naam;
        private int bezoekerID;
        private string locatie;

        public int BestandID 
        {
            set { bestandID = value; }
            get { return bestandID; }
        }
        public string Naam
        {
            set { naam = value; }
            get { return naam; }
        }

        public int BezoekerID
        {
            set { bezoekerID = value; }
            get { return bezoekerID; }
        }

        public string Locatie 
        {
            set { locatie = value; }
            get { return locatie; }
        }

        //De constructor voor een nieuwe bestand.
        public File(int bestandID, string naam, int bezoekerID)
        {
            this.bestandID = bestandID;
            this.naam = naam;
            this.bezoekerID = bezoekerID;
        }

        //De constructor voor een al bestaand bestand.
        public File(int bestandID, string naam, int bezoekerID, string locatie)
        {
            this.bestandID = bestandID;
            this.naam = naam;
            this.bezoekerID = bezoekerID;
            this.locatie = locatie;
        }

        public override string ToString()
        {
            //betere format bedenken + upvote en downvotes per file
            return String.Format("ID: {0}, Naam: {1}", bestandID, locatie);
        }
    }
}
