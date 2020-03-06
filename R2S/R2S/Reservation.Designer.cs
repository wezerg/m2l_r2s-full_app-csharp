namespace R2S
{
    partial class Reservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_reservation = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_raison = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_salle = new System.Windows.Forms.Label();
            this.lbl_jour = new System.Windows.Forms.Label();
            this.lbl_heure_debut = new System.Windows.Forms.Label();
            this.lbl_heure_fin = new System.Windows.Forms.Label();
            this.lbl_nom_result = new System.Windows.Forms.Label();
            this.lbl_salle_result = new System.Windows.Forms.Label();
            this.lbl_jour_result = new System.Windows.Forms.Label();
            this.lbl_heure_debut_result = new System.Windows.Forms.Label();
            this.lbl_heure_fin_result = new System.Windows.Forms.Label();
            this.tbx_raison_result = new System.Windows.Forms.TextBox();
            this.lbl_reservation_confirm = new System.Windows.Forms.Label();
            this.lbl_ligue_result = new System.Windows.Forms.Label();
            this.lbl_ligue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_reservation
            // 
            this.lbl_reservation.AutoSize = true;
            this.lbl_reservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reservation.Location = new System.Drawing.Point(22, 19);
            this.lbl_reservation.Name = "lbl_reservation";
            this.lbl_reservation.Size = new System.Drawing.Size(261, 17);
            this.lbl_reservation.TabIndex = 0;
            this.lbl_reservation.Text = "Récapitulatif de votre réservation :";
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(87, 347);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(89, 36);
            this.btn_confirm.TabIndex = 1;
            this.btn_confirm.Text = "Confirmer";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(278, 347);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(89, 36);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Annuler";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_raison
            // 
            this.lbl_raison.AutoSize = true;
            this.lbl_raison.Location = new System.Drawing.Point(22, 53);
            this.lbl_raison.Name = "lbl_raison";
            this.lbl_raison.Size = new System.Drawing.Size(147, 17);
            this.lbl_raison.TabIndex = 3;
            this.lbl_raison.Text = "Raison de la réunion :";
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(22, 90);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(122, 17);
            this.lbl_nom.TabIndex = 4;
            this.lbl_nom.Text = "Nom du créateur :";
            // 
            // lbl_salle
            // 
            this.lbl_salle.AutoSize = true;
            this.lbl_salle.Location = new System.Drawing.Point(22, 129);
            this.lbl_salle.Name = "lbl_salle";
            this.lbl_salle.Size = new System.Drawing.Size(118, 17);
            this.lbl_salle.TabIndex = 5;
            this.lbl_salle.Text = "Salle concernée :";
            // 
            // lbl_jour
            // 
            this.lbl_jour.AutoSize = true;
            this.lbl_jour.Location = new System.Drawing.Point(22, 204);
            this.lbl_jour.Name = "lbl_jour";
            this.lbl_jour.Size = new System.Drawing.Size(44, 17);
            this.lbl_jour.TabIndex = 6;
            this.lbl_jour.Text = "Jour :";
            // 
            // lbl_heure_debut
            // 
            this.lbl_heure_debut.AutoSize = true;
            this.lbl_heure_debut.Location = new System.Drawing.Point(22, 243);
            this.lbl_heure_debut.Name = "lbl_heure_debut";
            this.lbl_heure_debut.Size = new System.Drawing.Size(115, 17);
            this.lbl_heure_debut.TabIndex = 7;
            this.lbl_heure_debut.Text = "Heure de début :";
            // 
            // lbl_heure_fin
            // 
            this.lbl_heure_fin.AutoSize = true;
            this.lbl_heure_fin.Location = new System.Drawing.Point(22, 279);
            this.lbl_heure_fin.Name = "lbl_heure_fin";
            this.lbl_heure_fin.Size = new System.Drawing.Size(94, 17);
            this.lbl_heure_fin.TabIndex = 8;
            this.lbl_heure_fin.Text = "Heure de fin :";
            // 
            // lbl_nom_result
            // 
            this.lbl_nom_result.AutoSize = true;
            this.lbl_nom_result.Location = new System.Drawing.Point(293, 90);
            this.lbl_nom_result.Name = "lbl_nom_result";
            this.lbl_nom_result.Size = new System.Drawing.Size(100, 17);
            this.lbl_nom_result.TabIndex = 9;
            this.lbl_nom_result.Text = "lbl_nom_result";
            // 
            // lbl_salle_result
            // 
            this.lbl_salle_result.AutoSize = true;
            this.lbl_salle_result.Location = new System.Drawing.Point(293, 129);
            this.lbl_salle_result.Name = "lbl_salle_result";
            this.lbl_salle_result.Size = new System.Drawing.Size(102, 17);
            this.lbl_salle_result.TabIndex = 10;
            this.lbl_salle_result.Text = "lbl_salle_result";
            // 
            // lbl_jour_result
            // 
            this.lbl_jour_result.AutoSize = true;
            this.lbl_jour_result.Location = new System.Drawing.Point(293, 204);
            this.lbl_jour_result.Name = "lbl_jour_result";
            this.lbl_jour_result.Size = new System.Drawing.Size(97, 17);
            this.lbl_jour_result.TabIndex = 11;
            this.lbl_jour_result.Text = "lbl_jour_result";
            // 
            // lbl_heure_debut_result
            // 
            this.lbl_heure_debut_result.AutoSize = true;
            this.lbl_heure_debut_result.Location = new System.Drawing.Point(293, 243);
            this.lbl_heure_debut_result.Name = "lbl_heure_debut_result";
            this.lbl_heure_debut_result.Size = new System.Drawing.Size(154, 17);
            this.lbl_heure_debut_result.TabIndex = 12;
            this.lbl_heure_debut_result.Text = "lbl_heure_debut_result";
            // 
            // lbl_heure_fin_result
            // 
            this.lbl_heure_fin_result.AutoSize = true;
            this.lbl_heure_fin_result.Location = new System.Drawing.Point(293, 279);
            this.lbl_heure_fin_result.Name = "lbl_heure_fin_result";
            this.lbl_heure_fin_result.Size = new System.Drawing.Size(133, 17);
            this.lbl_heure_fin_result.TabIndex = 13;
            this.lbl_heure_fin_result.Text = "lbl_heure_fin_result";
            // 
            // tbx_raison_result
            // 
            this.tbx_raison_result.Location = new System.Drawing.Point(296, 50);
            this.tbx_raison_result.Name = "tbx_raison_result";
            this.tbx_raison_result.Size = new System.Drawing.Size(149, 22);
            this.tbx_raison_result.TabIndex = 14;
            // 
            // lbl_reservation_confirm
            // 
            this.lbl_reservation_confirm.AutoSize = true;
            this.lbl_reservation_confirm.Location = new System.Drawing.Point(116, 317);
            this.lbl_reservation_confirm.Name = "lbl_reservation_confirm";
            this.lbl_reservation_confirm.Size = new System.Drawing.Size(228, 17);
            this.lbl_reservation_confirm.TabIndex = 15;
            this.lbl_reservation_confirm.Text = "Confirmez vous votre réservation ?";
            // 
            // lbl_ligue_result
            // 
            this.lbl_ligue_result.AutoSize = true;
            this.lbl_ligue_result.Location = new System.Drawing.Point(293, 168);
            this.lbl_ligue_result.Name = "lbl_ligue_result";
            this.lbl_ligue_result.Size = new System.Drawing.Size(103, 17);
            this.lbl_ligue_result.TabIndex = 17;
            this.lbl_ligue_result.Text = "lbl_ligue_result";
            // 
            // lbl_ligue
            // 
            this.lbl_ligue.AutoSize = true;
            this.lbl_ligue.Location = new System.Drawing.Point(22, 168);
            this.lbl_ligue.Name = "lbl_ligue";
            this.lbl_ligue.Size = new System.Drawing.Size(122, 17);
            this.lbl_ligue.TabIndex = 16;
            this.lbl_ligue.Text = "Ligue concernée :";
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 408);
            this.Controls.Add(this.lbl_ligue_result);
            this.Controls.Add(this.lbl_ligue);
            this.Controls.Add(this.lbl_reservation_confirm);
            this.Controls.Add(this.tbx_raison_result);
            this.Controls.Add(this.lbl_heure_fin_result);
            this.Controls.Add(this.lbl_heure_debut_result);
            this.Controls.Add(this.lbl_jour_result);
            this.Controls.Add(this.lbl_salle_result);
            this.Controls.Add(this.lbl_nom_result);
            this.Controls.Add(this.lbl_heure_fin);
            this.Controls.Add(this.lbl_heure_debut);
            this.Controls.Add(this.lbl_jour);
            this.Controls.Add(this.lbl_salle);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.lbl_raison);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.lbl_reservation);
            this.MaximumSize = new System.Drawing.Size(486, 455);
            this.MinimumSize = new System.Drawing.Size(486, 455);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_reservation;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_raison;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_salle;
        private System.Windows.Forms.Label lbl_jour;
        private System.Windows.Forms.Label lbl_heure_debut;
        private System.Windows.Forms.Label lbl_heure_fin;
        private System.Windows.Forms.Label lbl_nom_result;
        private System.Windows.Forms.Label lbl_salle_result;
        private System.Windows.Forms.Label lbl_jour_result;
        private System.Windows.Forms.Label lbl_heure_debut_result;
        private System.Windows.Forms.Label lbl_heure_fin_result;
        private System.Windows.Forms.TextBox tbx_raison_result;
        private System.Windows.Forms.Label lbl_reservation_confirm;
        private System.Windows.Forms.Label lbl_ligue_result;
        private System.Windows.Forms.Label lbl_ligue;
    }
}