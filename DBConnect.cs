/* 
 * Deze classe is om de connectie met de database en het uitvoeren van queries mogelijk te maken
 * de volgende queries worden ondersteund
 *  -select
 *  -delete
 *  -update
 *  -insert
 * kijk bij de functie om te zien hoe ze werken
 * voor dat het mogelijk is om connectie te maken moetten eerst de gegevens van jou database worden ingevoerd in de constructor hieronder
 * voor custom queries kun je de functie ExecuteQuery gebruiken dit geldt alleen voor DDL of DML
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace FileShare
{
    class DBconnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private static DBconnect _instance = new DBconnect();
        //Constructor
        private DBconnect()
        {
            Initialize();
        }

        public static DBconnect Instantie
        {
            get
            {
                return _instance;
            }
        }

        //Initialize values
        private void Initialize()
        {
            Console.WriteLine("CONSTRUCTOR UITGEVOERD");
            server = "localhost";
            database = "sme";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            if (!(connection.State.Equals(ConnectionState.Open)))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            MessageBox.Show("Kan geen contact maken met de database, neem contact met de admin op");
                            break;

                        case 1045:
                            MessageBox.Show("Verkeerde gebruikersnaam/wachtwoord");
                            break;
                    }

                }
            }
            else
            {
                return true;
            }
            return false;

        }

        //Close connection
        private bool CloseConnection()
        {

            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void ExecuteQuery(string query)
        {
            if (this.OpenConnection() == true)
            {
                Console.WriteLine(query);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();

                this.CloseConnection();
            }
        }


        //Insert statement voor een insert in de database data is de te inserten data, tabel de tabel en velden de velden waar de data in moet. De data en velden moeten gescheiden worden door comma's
        public void Insert(string tabel, string data, string velden)
        {
            string query = "INSERT INTO " + tabel + " (" + velden + ") VALUES(" + data + ");";
            ExecuteQuery(query);
        }

        //Update statement
        public void Update(string tabel, string velden, string waar)
        {
            string query = "UPDATE " + tabel + " SET " + velden + " WHERE " + waar + ";";
            ExecuteQuery(query);
        }

        //Delete statement
        public void Delete(string tabel, string waar)
        {
            string query = "DELETE FROM " + tabel + " WHERE " + waar + ";";
            ExecuteQuery(query);
        }

        // Select statement
        public DataRow SingleSelect(string tabel, string velden, string waar = "1")
        {

            DataTable data = new DataTable();
            if (this.OpenConnection() == true)
            {
                string query = "SELECT " + velden + " FROM " + tabel + " WHERE " + waar + ";";
                Console.WriteLine(query);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                data.Load(cmd.ExecuteReader());
            }

            if (data.Rows.Count > 0)
            {
                DataRow rij = data.Rows[0];
                return rij;
            }
            else
            {
                return null;
            }

        }

        //select multiple
        public DataTable SelectMultiple(string tabel, string velden, string waar = "1", string extra = "")
        {
            DataTable data = new DataTable();
            if (this.OpenConnection() == true)
            {
                string query = "SELECT " + velden + " FROM " + tabel + " WHERE " + waar + extra + ";";
                Console.WriteLine(query);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                data.Load(cmd.ExecuteReader());
            }
            return data;
        }

        //Count statement
        public int Count(string tabel, string waar = "1=1")
        {
            string query = "SELECT COUNT(*) FROM " + tabel + " WHERE " + waar + ";";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }

        }

    }


}

