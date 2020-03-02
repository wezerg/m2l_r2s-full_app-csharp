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
    public partial class Administrateur : Form
    {
        public Administrateur()
        {
            InitializeComponent();
        }

        database db = new database();
        private void Administrateur_Shown(object sender, EventArgs e)
        {
            this.refreshList();
        }

        private void btn_admin_salarie_add_Click(object sender, EventArgs e)
        {
            db.ajouterSalarie();
            this.refreshList();
        }

        private void btn_admin_salarie_modif_Click(object sender, EventArgs e)
        {
            // Récupération de l'id du salarié sélectionné
            string valueCell = data_admin_salarie.Rows[data_admin_salarie.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
            db.modifierSalarie(valueCell);
            this.refreshList();
        }

        private void refreshList()
        {
            db.dbConnect();
            // Remplissage du tableau de salarié a l'ouverture du logiciel
            db.ShowData(data_admin_salarie, "SELECT u.id, u.nom, u.prenom, l.intitule, s.localisation FROM utilisateur u LEFT JOIN salle s on s.id = u.id_salle LEFT JOIN ligue l on l.id = u.id_ligue WHERE u.id_groupe_utilisateur = 2; ");
            // Remplissage du tableau de ligues à l'ouverture du logiciel
            db.ShowData(data_admin_ligue, "SELECT l.id, l.intitule FROM ligue l");
            // Remplissage du tableau de salles à l'ouverture du logiciel
            db.ShowData(data_admin_salle, "SELECT s.id, s.localisation FROM salle s");
            db.dbDisconnect();
        }

        private void btn_admin_ligue_add_Click(object sender, EventArgs e)
        {
            db.ajouterLigue();
            this.refreshList();
        }

        private void btn_admin_ligue_modif_Click(object sender, EventArgs e)
        {
            string valueCell = data_admin_ligue.Rows[data_admin_ligue.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
            db.modifierLigue(valueCell);
            this.refreshList();
        }

        private void btn_admin_salle_add_Click(object sender, EventArgs e)
        {
            db.ajouterSalle();
            this.refreshList();
        }

        private void btn_admin_salle_modif_Click(object sender, EventArgs e)
        {
            string valueCell = data_admin_salle.Rows[data_admin_salle.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
            db.modifierSalle(valueCell);
            this.refreshList();
        }

        private void btn_admin_salarie_remove_Click(object sender, EventArgs e)
        {
            string valueCell = data_admin_salarie.Rows[data_admin_salarie.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
            db.supprSalarie(valueCell);
            this.refreshList();
        }

        private void btn_admin_ligue_suppr_Click(object sender, EventArgs e)
        {
            string valueCell = data_admin_ligue.Rows[data_admin_ligue.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
            db.supprLigue(valueCell);
            this.refreshList();
        }

        private void btn_admin_salle_remove_Click(object sender, EventArgs e)
        {
            string valueCell = data_admin_salle.Rows[data_admin_salle.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
            db.supprSalle(valueCell);
            this.refreshList();
        }
    }
}
