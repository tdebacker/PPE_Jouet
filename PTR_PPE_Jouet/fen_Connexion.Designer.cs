namespace PTR_PPE_Jouet
{
    partial class fen_Connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fen_Connexion));
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_mdp = new System.Windows.Forms.Label();
            this.txtbox_login = new System.Windows.Forms.TextBox();
            this.txtbox_mdp = new System.Windows.Forms.TextBox();
            this.picbox_logo = new System.Windows.Forms.PictureBox();
            this.btn_connexion = new System.Windows.Forms.Button();
            this.lbl_titre_fen_Connexion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(197, 146);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(39, 13);
            this.lbl_login.TabIndex = 0;
            this.lbl_login.Text = "Login :";
            // 
            // lbl_mdp
            // 
            this.lbl_mdp.AutoSize = true;
            this.lbl_mdp.Location = new System.Drawing.Point(197, 197);
            this.lbl_mdp.Name = "lbl_mdp";
            this.lbl_mdp.Size = new System.Drawing.Size(78, 13);
            this.lbl_mdp.TabIndex = 1;
            this.lbl_mdp.Text = "Mot de Passe :";
            // 
            // txtbox_login
            // 
            this.txtbox_login.Location = new System.Drawing.Point(301, 143);
            this.txtbox_login.Name = "txtbox_login";
            this.txtbox_login.Size = new System.Drawing.Size(100, 20);
            this.txtbox_login.TabIndex = 2;
            // 
            // txtbox_mdp
            // 
            this.txtbox_mdp.Location = new System.Drawing.Point(301, 194);
            this.txtbox_mdp.Name = "txtbox_mdp";
            this.txtbox_mdp.PasswordChar = '•';
            this.txtbox_mdp.Size = new System.Drawing.Size(100, 20);
            this.txtbox_mdp.TabIndex = 3;
            // 
            // picbox_logo
            // 
            this.picbox_logo.Image = ((System.Drawing.Image)(resources.GetObject("picbox_logo.Image")));
            this.picbox_logo.Location = new System.Drawing.Point(497, 12);
            this.picbox_logo.Name = "picbox_logo";
            this.picbox_logo.Size = new System.Drawing.Size(284, 132);
            this.picbox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_logo.TabIndex = 4;
            this.picbox_logo.TabStop = false;
            // 
            // btn_connexion
            // 
            this.btn_connexion.Location = new System.Drawing.Point(291, 269);
            this.btn_connexion.Name = "btn_connexion";
            this.btn_connexion.Size = new System.Drawing.Size(175, 45);
            this.btn_connexion.TabIndex = 5;
            this.btn_connexion.Text = "Connexion";
            this.btn_connexion.UseVisualStyleBackColor = true;
            this.btn_connexion.Click += new System.EventHandler(this.btn_connexion_Click);
            // 
            // lbl_titre_fen_Connexion
            // 
            this.lbl_titre_fen_Connexion.AutoSize = true;
            this.lbl_titre_fen_Connexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre_fen_Connexion.Location = new System.Drawing.Point(286, 52);
            this.lbl_titre_fen_Connexion.Name = "lbl_titre_fen_Connexion";
            this.lbl_titre_fen_Connexion.Size = new System.Drawing.Size(160, 25);
            this.lbl_titre_fen_Connexion.TabIndex = 6;
            this.lbl_titre_fen_Connexion.Text = "Authentification";
            // 
            // fen_Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 374);
            this.Controls.Add(this.lbl_titre_fen_Connexion);
            this.Controls.Add(this.btn_connexion);
            this.Controls.Add(this.picbox_logo);
            this.Controls.Add(this.txtbox_mdp);
            this.Controls.Add(this.txtbox_login);
            this.Controls.Add(this.lbl_mdp);
            this.Controls.Add(this.lbl_login);
            this.Name = "fen_Connexion";
            this.Text = "Application Jouet";
            this.Load += new System.EventHandler(this.fen_Connexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_mdp;
        private System.Windows.Forms.TextBox txtbox_login;
        private System.Windows.Forms.TextBox txtbox_mdp;
        private System.Windows.Forms.PictureBox picbox_logo;
        private System.Windows.Forms.Button btn_connexion;
        private System.Windows.Forms.Label lbl_titre_fen_Connexion;
    }
}

