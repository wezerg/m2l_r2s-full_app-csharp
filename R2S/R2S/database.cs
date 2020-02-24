using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace R2S
{
    class database
    {
        // Appel de la classe password pour les hachages :
        // On créer la chaine de caractère de connexion à la BDD
        static string strConnection = "server=127.0.0.1;uid=root;password='@Aqw753+-/*';database=r2s";
        // Instanciation des différentes variables nécessaire au SQL.
        MySqlConnection sqlConnection = new MySqlConnection(strConnection);
        MySqlCommand sqlCommand = new MySqlCommand();
        MySqlDataReader sqlDataR;
        MySqlTransaction sqlTransaction;
        public database()
        {

        }

        public void dbConnect()
        {
            try
            {
                // Connexion SQL a la base de donnée
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion", ex.Message);
            }
        }

        public void dbDisconnect()
        {
            sqlConnection.Close();
        }

        public int userCertif(string strQuery, TextBox tbLogin, TextBox tbPassword)
        {
            int connecte = 0;
            // Set des valeurs de sqlCommand pour créer le lecteur sqlDataR
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = strQuery;
            // Mettre un booléen pour gérer le cas ou la chaine de connexion à la db est fausse
            sqlDataR = sqlCommand.ExecuteReader();
            // Boucle pour lire toutes les lignes de la bdd
            while (sqlDataR.Read())
            {
                if (sqlDataR.GetValue(0).ToString() == tbLogin.Text && sqlDataR.GetValue(1).ToString() == GetHashPassword(tbPassword.Text) && sqlDataR.GetValue(3).ToString() == "2")
                {
                    connecte = 2;
                    break;
                }
                if (sqlDataR.GetValue(0).ToString() == tbLogin.Text && sqlDataR.GetValue(1).ToString() == GetHashPassword(tbPassword.Text) && sqlDataR.GetValue(3).ToString() == "1")
                {
                    connecte = 1;
                    break;
                }
            }
            sqlDataR.Dispose();
            return connecte;
        }

        public int numRow(string strQuery)
        {
            // Attention : ne fonctionne pas avec les insert into -> rajouter une condition
            int x;
            // Boucle pour modifier la requete
            for (int i = 0; i < strQuery.Count(); i++)
            {
                if (strQuery[i].ToString() == " ")
                {
                    if (strQuery.Substring(i,2) == " *")
                    {
                        strQuery = "SELECT count(*)," + strQuery.Substring(i+2, (strQuery.Length - i-2));
                        break;
                    }
                    strQuery = "SELECT count(*)," + strQuery.Substring(i, (strQuery.Length - i));
                    break;
                }
            }
            // Etablissement de la requete
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = strQuery;
            sqlDataR = sqlCommand.ExecuteReader();
            sqlDataR.Read();
            // Fonctionne si il n'y a qu'une seule ligne ?
            x = sqlDataR.GetInt32(0);
            // Libération de la requete
            sqlCommand.Dispose();
            sqlDataR.Dispose();
            return x;
        }
        public string[,] dbQuery(string strQuery)
        {
            int y = numRow(strQuery);
            // On crée la connection a la base de donnée avec la requete nécessaire en paramètre
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = strQuery;
            sqlDataR = sqlCommand.ExecuteReader();

            // On créé le tableau adapté a la taille de la requete
            // A mettre ce chiffre dans le tableau
            string[,] queryReturn = new string[y, sqlDataR.FieldCount];
            int x = 0;
            while (sqlDataR.Read())
            {
                for (int i = 0; i < sqlDataR.FieldCount; i++)
                {
                    queryReturn[x, i] = sqlDataR.GetValue(i).ToString();
                }
                x++;
            }
            sqlDataR.Dispose();
            sqlCommand.Dispose();
            return queryReturn;
        }

        public string GetHashPassword(string input)
        {
            string strPassword;

            // Création de l'objet de hachage
            MD5 md5 = MD5.Create();
            // Encodage UTF-8 de la valeur input 
            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            // Boucle pour accrémenter le stringbuilder avec les bytes de data
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Passation du builder dans une variable qu'on retourne
            strPassword = sBuilder.ToString();
            // Décharge des données de la classe
            md5.Dispose();
            sBuilder.Remove(0, sBuilder.Length - 1);
            return strPassword;
        }

        public void ShowData(DataGridView gridView, string query)
        {
            // Vidage de la grille de donnée
            gridView.Rows.Clear();
            // Création de la requete
            string [,] strQuery = dbQuery(query);
            // Double boucle pour créer la datagridview désirée
            for (int i = 0; i < strQuery.GetLength(0); i++)
            {
                gridView.Rows.Add();
                for (int j = 0; j < strQuery.GetLength(1); j++)
                {
                    gridView.Rows[i].Cells[j].Value = strQuery[i, j];
                }
            }
        }

        public void insertDB(string nonQuery)
        {
            // Commencer la transaction
            sqlTransaction = sqlConnection.BeginTransaction();
            // Essayer les étapes
            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = nonQuery;
                sqlCommand.Transaction = sqlTransaction;
                sqlCommand.ExecuteNonQuery();
                sqlTransaction.Commit();
            } // Sinon arreter la transaction
            catch (MySqlException ex)
            {
                sqlTransaction.Rollback();
            }
            // Supprimer la commande
            sqlCommand.Dispose();
        }

        public void ajouter()
        {
            modifSalarie add = new modifSalarie(dbQuery("Hello World"));
        }
        public void modifier()
        {
            modifSalarie modif = new modifSalarie(dbQuery("Hello World"));
        }
    }
}
