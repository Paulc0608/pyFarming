using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace KontoProjekt
{
    public class Benutzer
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\Projekte\\Schule\\KontoProjekt\\KontoProjekt\\Passwords.mdf;Integrated Security=True";


       public bool IsUserCredentialsValid(string inputName, string inputVorname, string inputPassword)
        {
            bool credentialsValid = false;
            string queryString = "SELECT Name, Vorname, IBAN, Passwort FROM dbo.Benutzer";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader.GetString(0); 
                    string vorname = reader.GetString(1); 
                    string IBAN = reader.GetString(2);
                    string password = reader.GetString(3);

                    // Vergleichen der Daten mit der Eingabe
                    if (name == inputName && vorname == inputVorname && password == inputPassword)
                    {
                        credentialsValid = true;
                        break; // Wenn die richtigen werte gefunden wurden, die Schleife unterbrechen
                    }
                }

                reader.Close();
            }

            return credentialsValid;
        }

        


    }
}

