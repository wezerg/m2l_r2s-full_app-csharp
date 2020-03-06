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
    public partial class Accueil : Form
    {
        private string[,] affichageCalendar1 = new string[12, 3];
        private string[,] affichageCalendar2 = new string[12, 3];
        private string[,] infoConnexion;
        database db = new database();
        public Accueil(string[,] infoSalarie)
        {
            InitializeComponent();
            /* Incrémentation du tableau avec les données de l'utilisateur :
             * 0 -> Login ; 1 -> Password ; 2 -> ID ; 3 -> Droit ;
             * 4 -> ID Ligue ; 5 -> ID Salle; 6 -> Nom ; 7 -> Prénom ;
             */
            infoConnexion = infoSalarie;
            this.affichageCalendrier();
        }

        public void clickCalendar(object sender, EventArgs e)
        {
            // Lien entre le panel cliqué et sa nature pour accès a la méthode backcolor
            Panel p = (Panel) sender;
            if (p.BackColor == Color.LightGreen) // Selection du créneau horaire
            {
                p.BackColor = Color.LightBlue;
            }
            else if (p.BackColor == Color.LightBlue) // Déselection du créneaux horaire
            {
                p.BackColor = Color.LightGreen;
            }
            else // Avertissement, créneau déja existant
            {
                MessageBox.Show("Ce créneaux horaire est déja réservé", "Attention");
            }
        }

        private void accueil_calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            // Appel de la méthode pour afficher sur le tableau la journée selectionner dans le calendrier
            this.affichageCalendrier();
        }

        public void affichageCalendrier()
        {
            // REVOIR CETTE METHODE POUR L'AMELIORER ------------------>
            // Clean des panel de couleur + clean du tableau de donnée
            int refreshTab = 0;
            for (int i = 1; i < (affichageCalendar1.GetLength(0)+1); i++)
            {
                for (int j = 1; j < 3; j++)
                {
                    tbl_reservation.GetControlFromPosition(j, i).BackColor = Color.LightGreen;
                }
                affichageCalendar1[refreshTab, 0] = null;
                affichageCalendar1[refreshTab, 1] = null;
                affichageCalendar1[refreshTab, 2] = null;
                affichageCalendar2[refreshTab, 0] = null;
                affichageCalendar2[refreshTab, 1] = null;
                affichageCalendar2[refreshTab, 2] = null;
                refreshTab++;
            }

            string[,] tabQuery;
            // Formatage SQL des dates
            string dateSQLday1 = accueil_calendar.SelectionStart.ToShortDateString().Substring(6, 4) + "-" + accueil_calendar.SelectionStart.ToShortDateString().Substring(3, 2) + "-" + accueil_calendar.SelectionStart.ToShortDateString().Substring(0, 2);
            string dateSQLday2 = accueil_calendar.SelectionStart.AddDays(1).ToShortDateString().Substring(6, 4) + "-" + accueil_calendar.SelectionStart.AddDays(1).ToShortDateString().Substring(3, 2) + "-" + accueil_calendar.SelectionStart.AddDays(1).ToShortDateString().Substring(0, 2);
            // Mise a jour des dates des colonnes
            lbl_jour1.Text = "Date du jour sélectionné : " + accueil_calendar.SelectionStart.ToShortDateString();
            lbl_jour2.Text = "Date du lendemain : " + accueil_calendar.SelectionStart.AddDays(1).ToShortDateString();
            // Requete pour récupérer les réservations des deux jours selectionnés avec comme condition la salle de l'utilisateur
            db.dbConnect();
            tabQuery = db.dbQuery("SELECT id, date_debut, date_fin FROM reservation WHERE (DATE(date_debut) = " + '"' + dateSQLday1 + '"' + " || DATE(date_debut) = " + '"' + dateSQLday2 + '"' + ") && " + "id_salle = " + '"' + infoConnexion[0, 5] + '"' + ";");
            db.dbDisconnect();
            // Entrée des datetime dans le tableau d'affichage
            for (int i = 0; i < affichageCalendar1.GetLength(0); i++)
            {
                for (int j = 1; j < 3; j++)
                {
                    affichageCalendar1[i, j] = dateSQLday1 + " " + ((j == 2) ? ((i < 1) ? "0" + (9 + i) : "" + (9 + i)) : ((i <= 1) ? "0" + (8 + i) : "" + (8 + i))) + ":00:00";
                    affichageCalendar2[i, j] = dateSQLday2 + " " + ((j == 2) ? ((i < 1) ? "0" + (9 + i) : "" + (9 + i)) : ((i <= 1) ? "0" + (8 + i) : "" + (8 + i))) + ":00:00";
                }
            }
            // Attribution des id existants
            for (int i = 0; i < tabQuery.GetLength(0); i++)
            {
                for (int j = 0; j < affichageCalendar1.GetLength(0); j++)
                {
                    if (tabQuery[i, 1] == accueil_calendar.SelectionStart.ToShortDateString() + " " + ((j <= 1) ? "0" + (8 + j) : "" + (8 + j)) + ":00:00")
                    {
                        affichageCalendar1[j, 0] = tabQuery[i, 0];
                        affichageCalendar1[j, 2] = dateSQLday1 + " " + tabQuery[i, 2].Substring(11, 2) + ":00:00";
                    }
                    if (tabQuery[i, 1] == accueil_calendar.SelectionStart.AddDays(1).ToShortDateString() + " " + ((j <= 1) ? "0" + (8 + j) : "" + (8 + j)) + ":00:00")
                    {
                        affichageCalendar2[j, 0] = tabQuery[i, 0];
                        affichageCalendar2[j, 2] = dateSQLday2 + " " + tabQuery[i, 2].Substring(11, 2) + ":00:00";
                    }

                }
            }
            // Affichage des couleurs sur le tableau
            int indexTab = 0;
            int ecartHeureDay1 = 0;
            int ecartHeureDay2 = 0;
            for (int i = 1; i < affichageCalendar1.GetLength(0) + 1; i++)
            {
                if (affichageCalendar1[indexTab, 0] != null)
                {
                    tbl_reservation.GetControlFromPosition(1, i).BackColor = Color.Crimson;

                    ecartHeureDay1 = int.Parse(affichageCalendar1[indexTab, 2].Substring(11, 2)) - int.Parse(affichageCalendar1[indexTab, 1].Substring(11, 2));
                    for (int j = 0; j < ecartHeureDay1; j++)
                    {
                        tbl_reservation.GetControlFromPosition(1, i + j).BackColor = Color.Crimson;
                    }
                }
                if (affichageCalendar2[indexTab, 0] != null)
                {
                    tbl_reservation.GetControlFromPosition(2, i).BackColor = Color.Crimson;

                    ecartHeureDay2 = int.Parse(affichageCalendar2[indexTab, 2].Substring(11, 2)) - int.Parse(affichageCalendar2[indexTab, 1].Substring(11, 2));
                    for (int j = 0; j < ecartHeureDay2; j++)
                    {
                        tbl_reservation.GetControlFromPosition(2, i + j).BackColor = Color.Crimson;
                    }
                }
                indexTab++;
                ecartHeureDay1 = 0;
                ecartHeureDay2 = 0;
            }
        }

        private void btn_reservation_Click(object sender, EventArgs e)
        {
            // Tableau d'envoi de donnée au formulaire de confirmation
            string[,] returnValue = new string[1, 8];
            /* Incrémentation du tableau a envoyer pour la confirmation:
             * O -> Nom et prénom du créateur de la réservation ; 1 -> Salle ; 2 -> Ligue ;
             * 3 -> Jour ; 4 -> Heure de début ; 5 -> Heure de fin ; 6 -> id user ; 7 -> id_salle ;
             */
            db.dbConnect();
            returnValue[0, 0] = infoConnexion[0, 6] + " " + infoConnexion[0, 7];
            returnValue[0, 1] = db.dbQuery("SELECT salle.localisation FROM salle WHERE salle.id = " + '"' + infoConnexion[0, 5] + '"' + ";")[0, 0];
            returnValue[0, 2] = db.dbQuery("SELECT ligue.intitule FROM ligue WHERE ligue.id = " + '"' + infoConnexion[0, 4] + '"' + ";")[0, 0];
            returnValue[0, 6] = infoConnexion[0, 2];
            returnValue[0, 7] = infoConnexion[0, 5];
            db.dbDisconnect();
            // Systeme de boucle pour checker les créneaux selectionnés
            // Et création du tableau pour le form de confirmation
            for (int i = 1; i < 3; i++)
            {
                if (returnValue[0, 4] == null && returnValue[0, 5] == null)
                {
                    for (int j = 1; j < (affichageCalendar1.GetLength(0) + 1); j++)
                    {
                        if (tbl_reservation.GetControlFromPosition(i, j).BackColor == Color.LightBlue)
                        {
                            if (i == 1)
                            {
                                // Retour du jour
                                returnValue[0, 3] = affichageCalendar1[j - 1, 1].Substring(0, 10);
                                // Retour de l'heure de début
                                returnValue[0, 4] = affichageCalendar1[j - 1, 1].Substring(11, 8);
                                break;
                            }
                            else if (i == 2)
                            {
                                // Retour du jour
                                returnValue[0, 3] = affichageCalendar2[j - 1, 1].Substring(0, 10);
                                // Retour de l'heure de début
                                returnValue[0, 4] = affichageCalendar2[j - 1, 1].Substring(11, 8);
                                break;
                            }
                        }
                    }
                    for (int h = affichageCalendar1.GetLength(0); h > 0; h--)
                    {
                        if (tbl_reservation.GetControlFromPosition(i, h).BackColor == Color.LightBlue)
                        {
                            if (i == 1)
                            {
                                // Retour de l'heure de fin
                                returnValue[0, 5] = affichageCalendar1[h - 1, 2].Substring(11, 8);
                                break;
                            }
                            else if (i == 2)
                            {
                                // Retour de l'heure de fin
                                returnValue[0, 5] = affichageCalendar2[h - 1, 2].Substring(11, 8);
                                break;
                            }
                        }
                    }
                }
            }
            // Ouverture du form de confirmation
            Reservation resa = new Reservation(returnValue);
            resa.ShowDialog();
            this.affichageCalendrier();
        }
    }
}
