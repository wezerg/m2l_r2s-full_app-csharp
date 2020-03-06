using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R2S
{
    public partial class Reservation : Form
    {
        database db = new database();
        private string[,] envoiBDD = new string[1, 6];
        public Reservation(string [,] input)
        {
            /* Gérer les cas suivants :
             * Si aucun créneau n'est selectionnés
             * Si une réservation existe entre les deux créneaux choisi
             * Si c'est un dimanche
             * Si il y a plusieurs réservation, les séparés
             * A RAJOUTER AU BESOIN ------>
             * 
             */
            InitializeComponent();
            // Modification de l'affichage utilisateur en fonction des données envoyé par le précédent form
            lbl_nom_result.Text = input[0, 0];
            lbl_salle_result.Text = input[0, 1];
            lbl_ligue_result.Text = input[0, 2];
            lbl_jour_result.Text = input[0, 3].Substring(8, 2) + "/" + input[0, 3].Substring(5, 2) + "/" + input[0, 3].Substring(0, 4);
            lbl_heure_debut_result.Text = input[0, 4];
            lbl_heure_fin_result.Text = input[0, 5];

            /* Insertion dans le tableau de donnée a envoyer :
             * 0 -> intitulé de la requete pour le switch ; 1 -> raison ; 2 -> date et heure de début ;
             * 3 -> date et heure de fin ; 4 -> id_user ; 5 -> id_salle;
             */
            envoiBDD[0, 0] = "resa";
            envoiBDD[0, 2] = input[0, 3] + " " + input[0, 4];
            envoiBDD[0, 3] = input[0, 3] + " " + input[0, 5];
            envoiBDD[0, 4] = input[0, 6];
            envoiBDD[0, 5] = input[0, 7];
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (tbx_raison_result.Text.Trim() != "")
            {
                envoiBDD[0, 1] = tbx_raison_result.Text;
                db.dbConnect();
                db.updateDB(envoiBDD);
                db.dbDisconnect();
                // Fermeture du form
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Le champs raison ne peut pas être vide.", "Attention");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            // Retour au form du calendrier sans envoi en BDD
            this.Close();
            this.Dispose();
        }
    }
}
