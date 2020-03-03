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
        database db = new database();
        public Accueil()
        {
            InitializeComponent();
            lbl_jour1.Text = "Date du jour sélectionné : " + accueil_calendar.TodayDate.ToShortDateString();
            lbl_jour2.Text = "Date du lendemain : " + accueil_calendar.TodayDate.AddDays(1).ToShortDateString();
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
                MessageBox.Show("Ce créneaux horaire est déja réservée", "Attention");
            }
        }

        private void accueil_calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            // Clean du controle total
            int refreshTab = 0;
            for (int i = 1; i < 13; i++)
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
            // Requete pour récupérer les réservations des deux jours selectionnés
            db.dbConnect();
            tabQuery = db.dbQuery("SELECT id, date_debut, date_fin FROM reservation WHERE DATE(date_debut) = " + '"' + dateSQLday1 + '"' + " || DATE(date_debut) = " + '"' + dateSQLday2 + '"' +";");
            db.dbDisconnect();
            // Entrée des datetime dans le tableau d'affichage
            for (int i = 0; i < affichageCalendar1.GetLength(0); i++)
            {
                for (int j = 1; j < 3; j++)
                {
                    affichageCalendar1[i, j] = dateSQLday1 + " " + ((i <= 1) ? "0" + (8 + i) : "" + (8 + i)) + ":00:00";
                    affichageCalendar2[i, j] = dateSQLday2 + " " + ((i <= 1) ? "0" + (8 + i) : "" + (8 + i)) + ":00:00";
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
                    }
                    if (tabQuery[i, 1] == accueil_calendar.SelectionStart.AddDays(1).ToShortDateString() + " " + ((j <= 1) ? "0" + (8 + j) : "" + (8 + j)) + ":00:00")
                    {
                        affichageCalendar2[j, 0] = tabQuery[i, 0];
                    }
                    
                }
            }
            int indexTab = 0;
            for (int i = 1; i < affichageCalendar1.GetLength(0)+1; i++)
            {
                if (affichageCalendar1[indexTab, 0] != null)
                {
                    tbl_reservation.GetControlFromPosition(1, i).BackColor = Color.Crimson;
                }
                else if (affichageCalendar2[indexTab, 0] != null)
                {
                    tbl_reservation.GetControlFromPosition(2, i).BackColor = Color.Crimson;
                }
                indexTab++;
            }
        }
    }
}
