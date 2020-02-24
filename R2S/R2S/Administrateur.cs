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
            ajouterSalarie add = new ajouterSalarie();
            add.ShowDialog();
            this.refreshList();
        }

        private void refreshList()
        {
            db.dbConnect();
            // Remplissage du tableau de salarié a l'ouverture du logiciel
            db.ShowData(data_admin_salarie, "SELECT u.nom, u.prenom, l.intitule, s.localisation FROM utilisateur u LEFT JOIN salle s on s.id = u.id_salle LEFT JOIN ligue l on l.id = u.id_ligue WHERE u.id_groupe_utilisateur = 2; ");
            // Remplissage du tableau de ligues à l'ouverture du logiciel
            db.ShowData(data_admin_ligue, "SELECT l.id, l.intitule FROM ligue l");
            // Remplissage du tableau de salles à l'ouverture du logiciel
            db.ShowData(data_admin_salle, "SELECT s.id, s.localisation FROM salle s");
            db.dbDisconnect();
        }
    }
}
