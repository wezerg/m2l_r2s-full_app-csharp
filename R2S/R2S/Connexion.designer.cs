namespace R2S
{
    partial class Connexion
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
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.titre_connexion = new System.Windows.Forms.Label();
            this.pnl_connexion = new System.Windows.Forms.Panel();
            this.btn_connexion = new System.Windows.Forms.Button();
            this.pnl_connexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_password
            // 
            this.txt_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_password.Location = new System.Drawing.Point(253, 281);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_password.MaximumSize = new System.Drawing.Size(156, 20);
            this.txt_password.MinimumSize = new System.Drawing.Size(156, 20);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(156, 20);
            this.txt_password.TabIndex = 1;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // txt_login
            // 
            this.txt_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_login.Location = new System.Drawing.Point(253, 206);
            this.txt_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_login.MaximumSize = new System.Drawing.Size(156, 20);
            this.txt_login.MinimumSize = new System.Drawing.Size(156, 20);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(156, 20);
            this.txt_login.TabIndex = 0;
            // 
            // lbl_login
            // 
            this.lbl_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(130, 209);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(115, 17);
            this.lbl_login.TabIndex = 2;
            this.lbl_login.Text = "Nom de compte :";
            // 
            // lbl_password
            // 
            this.lbl_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(130, 284);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(101, 17);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Mot de passe :";
            // 
            // titre_connexion
            // 
            this.titre_connexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.titre_connexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre_connexion.Location = new System.Drawing.Point(113, 113);
            this.titre_connexion.MaximumSize = new System.Drawing.Size(321, 37);
            this.titre_connexion.MinimumSize = new System.Drawing.Size(321, 37);
            this.titre_connexion.Name = "titre_connexion";
            this.titre_connexion.Size = new System.Drawing.Size(321, 37);
            this.titre_connexion.TabIndex = 4;
            this.titre_connexion.Text = "Réservation de salle";
            this.titre_connexion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_connexion
            // 
            this.pnl_connexion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_connexion.Controls.Add(this.btn_connexion);
            this.pnl_connexion.Controls.Add(this.titre_connexion);
            this.pnl_connexion.Controls.Add(this.lbl_password);
            this.pnl_connexion.Controls.Add(this.lbl_login);
            this.pnl_connexion.Controls.Add(this.txt_login);
            this.pnl_connexion.Controls.Add(this.txt_password);
            this.pnl_connexion.Location = new System.Drawing.Point(16, 15);
            this.pnl_connexion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_connexion.Name = "pnl_connexion";
            this.pnl_connexion.Size = new System.Drawing.Size(533, 604);
            this.pnl_connexion.TabIndex = 5;
            // 
            // btn_connexion
            // 
            this.btn_connexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_connexion.Location = new System.Drawing.Point(134, 348);
            this.btn_connexion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_connexion.MaximumSize = new System.Drawing.Size(276, 26);
            this.btn_connexion.MinimumSize = new System.Drawing.Size(276, 26);
            this.btn_connexion.Name = "btn_connexion";
            this.btn_connexion.Size = new System.Drawing.Size(276, 26);
            this.btn_connexion.TabIndex = 5;
            this.btn_connexion.Text = "Connexion";
            this.btn_connexion.UseVisualStyleBackColor = true;
            this.btn_connexion.Click += new System.EventHandler(this.btn_connexion_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 633);
            this.Controls.Add(this.pnl_connexion);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(583, 680);
            this.MinimumSize = new System.Drawing.Size(583, 680);
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.pnl_connexion.ResumeLayout(false);
            this.pnl_connexion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label titre_connexion;
        private System.Windows.Forms.Panel pnl_connexion;
        private System.Windows.Forms.Button btn_connexion;
        internal System.Windows.Forms.TextBox txt_login;
    }
}