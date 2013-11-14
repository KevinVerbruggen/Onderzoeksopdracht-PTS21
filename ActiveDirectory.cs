using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;

namespace FileShare
{
    class ActiveDirectory
    {
        // algemene variabelen

        private static bool authentic = false;

        private static string domain;

        // properties

        public static bool Authentic {
            get { return authentic; }
            set { authentic = value; }
        }

        // om te kijken of iets bestaat (handig als je users aan groepen toevoegd)

        public static bool Exists(string objectPath)
        {
            bool found = false;
            if (DirectoryEntry.Exists("LDAP://" + domain + "/" + objectPath))
            {
                found = true;
            }
            return found;
        }

        //voor de authenticatie van een gebruiker

        public static bool Authenticate(string userName, string password, string domainip)
        {
            bool authentic = false;
            try
            {
                DirectoryEntry entry = new DirectoryEntry("LDAP://" + domainip, userName, password);
                object nativeObject = entry.NativeObject;
                authentic = true;
                domain = domainip;
            }
            catch (DirectoryServicesCOMException) { }
            return authentic;
        }

        public static void AuthenticateFailed() 
        {
            Console.WriteLine("Niet ingelogd.");
        }

        // voor het toevoegen van een user

        public static void CreateUserAccount(string ldapPath, string userName, string userPassword)
        {
            if (authentic)
            {
                string oGUID = string.Empty;
                try
                {
                    string connectionPrefix = "LDAP://" + domain + "/" + ldapPath;
                    DirectoryEntry dirEntry = new DirectoryEntry(connectionPrefix);
                    DirectoryEntry newUser = dirEntry.Children.Add
                        ("CN=" + userName, "user");
                    newUser.Properties["SAMAccountName"].Value = userName;
                    newUser.CommitChanges();
                    oGUID = newUser.Guid.ToString();

                    newUser.Invoke("SetPassword", new object[] { userPassword });
                    newUser.CommitChanges();
                    dirEntry.Close();
                    newUser.Close();
                }
                catch (System.DirectoryServices.DirectoryServicesCOMException E)
                {
                    Console.WriteLine(E);

                }
            }
            else 
            {
                AuthenticateFailed();
            }
        }

        // voor het verwijderen van een user

        public void DeleteUserAccount(string ldapPath, string username)
        {
            if (authentic)
            {
                if (!DirectoryEntry.Exists("LDAP://" + domain + "/" + ldapPath))
                {
                    DirectoryEntry ent = new DirectoryEntry("LDAP://" + domain);
                    DirectorySearcher dsrc = new DirectorySearcher(ent);
                    dsrc.Filter = string.Format("(&(objectClass=user)(objectCategory=person)(SAMAccountName=" + username + "))");
                    DirectoryEntry user = ent.Children.Find("CN=" + username, "objectClass=user");
                    ent.Children.Remove(user);
                    ent.Close();
                    user.Close();
                    dsrc.Dispose();
                }
                else
                {
                    Console.WriteLine(username + " bestaat niet");
                }
            }
            else 
            {
                AuthenticateFailed();
            }
        }

        // voor het aanpassen/updaten van een user

        public void EditUserAccount(string ldapPath, string username, string property, string newValue) 
        {
            if (authentic)
            {
                DirectoryEntry user = LoadUser(username);
                user.Properties[property].Value = newValue;
                user.CommitChanges();
            }
            else 
            {
                AuthenticateFailed();
            }
        }

        // voor het toevoegen van een groep

        public static void Create(string ouPath, string name)
        {
            if (authentic)
            {
                if (!DirectoryEntry.Exists("LDAP://" + domain + "/CN=" + name + "," + ouPath))
                {
                    try
                    {
                        DirectoryEntry entry = new DirectoryEntry("LDAP://" + domain + "/" + ouPath);
                        DirectoryEntry group = entry.Children.Add("CN=" + name, "group");
                        group.Properties["SAMAccountName"].Value = name;
                        group.CommitChanges();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message.ToString());
                    }
                }
                else { Console.WriteLine(ouPath + " bestaat al"); }
            }
            else 
            {
                AuthenticateFailed();
            }
        }

        // voor het verwijderen van een groep 

        public static void Delete(string ouPath, string groupPath)
        {
            if (authentic)
            {
                if (DirectoryEntry.Exists("LDAP://" + domain + "/" + groupPath))
                {
                    try
                    {
                        DirectoryEntry entry = new DirectoryEntry("LDAP://" + domain + "/" + ouPath);
                        DirectoryEntry group = new DirectoryEntry("LDAP://" + domain + "/" + groupPath);
                        entry.Children.Remove(group);
                        group.CommitChanges();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message.ToString());
                    }
                }
                else
                {
                    Console.WriteLine(ouPath + " bestaat niet in deze groep");
                }
            }
            else 
            {
                AuthenticateFailed();
            }
        }

        // voor het toevoegen van een user aan een groep

        public static void AddToGroup(string userDn, string groupDn)
        {
            if (authentic)
            {
                try
                {
                    DirectoryEntry dirEntry = new DirectoryEntry("LDAP://" + domain + "/" + groupDn);
                    dirEntry.Properties["member"].Add(userDn);
                    dirEntry.CommitChanges();
                    dirEntry.Close();
                }
                catch (System.DirectoryServices.DirectoryServicesCOMException)
                {

                }
            }
            else 
            {
                AuthenticateFailed();
            }
        }

        // voor het verwijderen van een user uit een groep (dus alleen uit een groep halen)

        public static void RemoveUserFromGroup(string userDn, string groupDn)
        {
            if (authentic)
            {
                try
                {
                    DirectoryEntry dirEntry = new DirectoryEntry("LDAP://" + domain + "/" + groupDn);
                    dirEntry.Properties["member"].Remove(userDn);
                    dirEntry.CommitChanges();
                    dirEntry.Close();
                }
                catch (System.DirectoryServices.DirectoryServicesCOMException E)
                {
                    Console.WriteLine(E);

                }
            }
            else 
            {
                AuthenticateFailed();
            }
        }

        // laad een user uit de AD, zodat die in andere functies gebruikt kan worden
        
        public static DirectoryEntry LoadUser(string username) 
        {
            if (authentic)
            {
                DirectoryEntry ent = new DirectoryEntry("LDAP://" + domain);
                DirectorySearcher dsrc = new DirectorySearcher(ent);
                dsrc.Filter = string.Format("(&(objectClass=user)(objectCategory=person)(SAMAccountName= " + username + "))");
                return dsrc.FindOne().GetDirectoryEntry();
            }
            else 
            {
                AuthenticateFailed();
                return null;
            }
        }

        // user als string weergeven

        public static string UserToString(string username) 
        {
            if (authentic)
            {
                DirectoryEntry user = LoadUser(username);
                return "Accountnaam = " + username + "\nNaam = " + user.Properties["DisplayName"] + "\nWachtwoord = " + user.Properties["password"];
            }
            else 
            {
                AuthenticateFailed();
                return "";
            }
        }

        // vind users

        public static void FindUser(string searchquery) 
        {
            DirectoryEntry ent = new DirectoryEntry("LDAP://" + domain);
            DirectorySearcher dsrc = new DirectorySearcher(ent);
            dsrc.Filter = string.Format("(&(objectClass=user)(objectCategory=person)(SAMAccountName= *" + searchquery + "*))");
            SearchResultCollection results = dsrc.FindAll();
            foreach (SearchResult result in results) 
            {
                Console.Write(UserToString(result.Properties["SAMAccountName"].ToString()));
            }
        }
        

    }
}
