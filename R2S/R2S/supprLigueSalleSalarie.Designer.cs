namespace R2S
{
    partial class supprLigueSalleSalarie
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
            this.lbl_suppr = new System.Windows.Forms.Label();
            this.btn_confirm_suppr = new System.Windows.Forms.Button();
            this.btn_cancel_suppr = new System.Windows.Forms.Button();
            this.lbl_suppr_nom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_suppr
            // 
            this.lbl_suppr.AutoSize = true;
            this.lbl_suppr.Location = new System.Drawing.Point(45, 45);
            this.lbl_suppr.Name = "lbl_suppr";
            this.lbl_suppr.Size = new System.Drawing.Size(46, 17);
            this.lbl_suppr.TabIndex = 0;
            this.lbl_suppr.Text = "label1";
            // 
            // btn_confirm_suppr
            // 
            this.btn_confirm_suppr.Location = new System.Drawing.Point(48, 110);
            this.btn_confirm_suppr.Name = "btn_confirm_suppr";
            this.btn_confirm_suppr.Size = new System.Drawing.Size(94, 45);
            this.btn_confirm_suppr.TabIndex = 1;
            this.btn_confirm_suppr.Text = "Confirmer";
            this.btn_confirm_suppr.UseVisualStyleBackColor = true;
            this.btn_confirm_suppr.Click += new System.EventHandler(this.btn_confirm_suppr_Click);
            // 
            // btn_cancel_suppr
            // 
            this.btn_cancel_suppr.Location = new System.Drawing.Point(181, 110);
            this.btn_cancel_suppr.Name = "btn_cancel_suppr";
            this.btn_cancel_suppr.Size = new System.Drawing.Size(94, 45);
            this.btn_cancel_suppr.TabIndex = 2;
            this.btn_cancel_suppr.Text = "Annuler";
            this.btn_cancel_suppr.UseVisualStyleBackColor = true;
            this.btn_cancel_suppr.Click += new System.EventHandler(this.btn_cancel_suppr_Click);
            // 
            // lbl_suppr_nom
            // 
            this.lbl_suppr_nom.AutoSize = true;
            this.lbl_suppr_nom.Location = new System.Drawing.Point(45, 75);
            this.lbl_suppr_nom.Name = "lbl_suppr_nom";
            this.lbl_suppr_nom.Size = new System.Drawing.Size(46, 17);
            this.lbl_suppr_nom.TabIndex = 3;
            this.lbl_suppr_nom.Text = "label1";
            // 
            // supprLigueSalleSalarie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 195);
            this.Controls.Add(this.lbl_suppr_nom);
            this.Controls.Add(this.btn_cancel_suppr);
            this.Controls.Add(this.btn_confirm_suppr);
            this.Controls.Add(this.lbl_suppr);
            this.MaximumSize = new System.Drawing.Size(351, 242);
            this.MinimumSize = new System.Drawing.Size(351, 242);
            this.Name = "supprLigueSalleSalarie";
            this.Text = "supprLigueSalleSalarie";
            this.Load += new System.EventHandler(this.supprLigueSalleSalarie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_suppr;
        private System.Windows.Forms.Button btn_confirm_suppr;
        private System.Windows.Forms.Button btn_cancel_suppr;
        private System.Windows.Forms.Label lbl_suppr_nom;
    }
}