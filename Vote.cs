using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileShare
{
    class Vote
    {
        //Benodigde variabelen.
        private string voterID;
        private string bestandID;
        private bool upvote;

        //Properties vaststellen
        public string VoterID 
        {
            get { return voterID; }
        }

        public string BestandID 
        {
            get { return bestandID; }
        }

        //De constructor. Met deze functie wordt een vote aangemaakt.
        public Vote(string voterID, string bestandID, string upvote) {
            this.voterID = voterID;
            this.bestandID = bestandID;
            this.upvote = mainclass.StringToBool(upvote);
        }

    }
}
