namespace PTR_PPE_Jouet
{
    partial class Fen_GestionEmploye
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
            this.btnValider = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.panelGestionEmploye = new System.Windows.Forms.Panel();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblEmploy = new System.Windows.Forms.Label();
            this.txt_cp = new System.Windows.Forms.TextBox();
            this.lblCp = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.lblmail = new System.Windows.Forms.Label();
            this.panelGestionEnfants = new System.Windows.Forms.Panel();
            this.txt_ageE = new System.Windows.Forms.TextBox();
            this.lblage = new System.Windows.Forms.Label();
            this.txt_nomE = new System.Windows.Forms.TextBox();
            this.lblNomE = new System.Windows.Forms.Label();
            this.lblPrenomE = new System.Windows.Forms.Label();
            this.txt_prenomE = new System.Windows.Forms.TextBox();
            this.cb_enfant = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.panelGestionEmploye.SuspendLayout();
            this.panelGestionEnfants.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(331, 265);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(118, 32);
            this.btnValider.TabIndex = 0;
            this.btnValider.Text = "VALIDER";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(15, 51);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom :";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(82, 48);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(100, 20);
            this.txt_nom.TabIndex = 2;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(82, 76);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(100, 20);
            this.txt_prenom.TabIndex = 4;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(15, 79);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 3;
            this.lblPrenom.Text = "Prenom :";
            // 
            // panelGestionEmploye
            // 
            this.panelGestionEmploye.Controls.Add(this.txt_numero);
            this.panelGestionEmploye.Controls.Add(this.lblNum);
            this.panelGestionEmploye.Controls.Add(this.lblEmploy);
            this.panelGestionEmploye.Controls.Add(this.txt_cp);
            this.panelGestionEmploye.Controls.Add(this.lblCp);
            this.panelGestionEmploye.Controls.Add(this.txtVille);
            this.panelGestionEmploye.Controls.Add(this.txtRue);
            this.panelGestionEmploye.Controls.Add(this.txt_email);
            this.panelGestionEmploye.Controls.Add(this.lblVille);
            this.panelGestionEmploye.Controls.Add(this.lblRue);
            this.panelGestionEmploye.Controls.Add(this.lblmail);
            this.panelGestionEmploye.Controls.Add(this.txt_nom);
            this.panelGestionEmploye.Controls.Add(this.lblNom);
            this.panelGestionEmploye.Controls.Add(this.lblPrenom);
            this.panelGestionEmploye.Controls.Add(this.txt_prenom);
            this.panelGestionEmploye.Location = new System.Drawing.Point(12, 12);
            this.panelGestionEmploye.Name = "panelGestionEmploye";
            this.panelGestionEmploye.Size = new System.Drawing.Size(200, 295);
            this.panelGestionEmploye.TabIndex = 5;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(82, 253);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(100, 20);
            this.txt_numero.TabIndex = 15;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(15, 256);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(50, 13);
            this.lblNum.TabIndex = 14;
            this.lblNum.Text = "Numero :";
            // 
            // lblEmploy
            // 
            this.lblEmploy.AutoSize = true;
            this.lblEmploy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmploy.Location = new System.Drawing.Point(59, 11);
            this.lblEmploy.Name = "lblEmploy";
            this.lblEmploy.Size = new System.Drawing.Size(81, 17);
            this.lblEmploy.TabIndex = 13;
            this.lblEmploy.Text = "EMPLOYÉ";
            // 
            // txt_cp
            // 
            this.txt_cp.Location = new System.Drawing.Point(82, 225);
            this.txt_cp.Name = "txt_cp";
            this.txt_cp.Size = new System.Drawing.Size(100, 20);
            this.txt_cp.TabIndex = 12;
            // 
            // lblCp
            // 
            this.lblCp.AutoSize = true;
            this.lblCp.Location = new System.Drawing.Point(15, 228);
            this.lblCp.Name = "lblCp";
            this.lblCp.Size = new System.Drawing.Size(49, 13);
            this.lblCp.TabIndex = 11;
            this.lblCp.Text = "CPostal :";
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(82, 199);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(100, 20);
            this.txtVille.TabIndex = 10;
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(82, 173);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(100, 20);
            this.txtRue.TabIndex = 9;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(82, 121);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 20);
            this.txt_email.TabIndex = 8;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(15, 202);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(32, 13);
            this.lblVille.TabIndex = 7;
            this.lblVille.Text = "Ville :";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Location = new System.Drawing.Point(15, 176);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(33, 13);
            this.lblRue.TabIndex = 6;
            this.lblRue.Text = "Rue :";
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Location = new System.Drawing.Point(15, 124);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(38, 13);
            this.lblmail.TabIndex = 5;
            this.lblmail.Text = "Email :";
            // 
            // panelGestionEnfants
            // 
            this.panelGestionEnfants.Controls.Add(this.txt_ageE);
            this.panelGestionEnfants.Controls.Add(this.lblage);
            this.panelGestionEnfants.Controls.Add(this.txt_nomE);
            this.panelGestionEnfants.Controls.Add(this.lblNomE);
            this.panelGestionEnfants.Controls.Add(this.lblPrenomE);
            this.panelGestionEnfants.Controls.Add(this.txt_prenomE);
            this.panelGestionEnfants.Controls.Add(this.cb_enfant);
            this.panelGestionEnfants.Controls.Add(this.label1);
            this.panelGestionEnfants.Location = new System.Drawing.Point(237, 12);
            this.panelGestionEnfants.Name = "panelGestionEnfants";
            this.panelGestionEnfants.Size = new System.Drawing.Size(212, 213);
            this.panelGestionEnfants.TabIndex = 6;
            // 
            // txt_ageE
            // 
            this.txt_ageE.Location = new System.Drawing.Point(82, 167);
            this.txt_ageE.Name = "txt_ageE";
            this.txt_ageE.Size = new System.Drawing.Size(100, 20);
            this.txt_ageE.TabIndex = 21;
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(15, 171);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(32, 13);
            this.lblage.TabIndex = 20;
            this.lblage.Text = "Age :";
            // 
            // txt_nomE
            // 
            this.txt_nomE.Location = new System.Drawing.Point(82, 96);
            this.txt_nomE.Name = "txt_nomE";
            this.txt_nomE.Size = new System.Drawing.Size(100, 20);
            this.txt_nomE.TabIndex = 17;
            // 
            // lblNomE
            // 
            this.lblNomE.AutoSize = true;
            this.lblNomE.Location = new System.Drawing.Point(15, 99);
            this.lblNomE.Name = "lblNomE";
            this.lblNomE.Size = new System.Drawing.Size(35, 13);
            this.lblNomE.TabIndex = 16;
            this.lblNomE.Text = "Nom :";
            // 
            // lblPrenomE
            // 
            this.lblPrenomE.AutoSize = true;
            this.lblPrenomE.Location = new System.Drawing.Point(15, 127);
            this.lblPrenomE.Name = "lblPrenomE";
            this.lblPrenomE.Size = new System.Drawing.Size(49, 13);
            this.lblPrenomE.TabIndex = 18;
            this.lblPrenomE.Text = "Prenom :";
            // 
            // txt_prenomE
            // 
            this.txt_prenomE.Location = new System.Drawing.Point(82, 124);
            this.txt_prenomE.Name = "txt_prenomE";
            this.txt_prenomE.Size = new System.Drawing.Size(100, 20);
            this.txt_prenomE.TabIndex = 19;
            // 
            // cb_enfant
            // 
            this.cb_enfant.FormattingEnabled = true;
            this.cb_enfant.Location = new System.Drawing.Point(33, 48);
            this.cb_enfant.Name = "cb_enfant";
            this.cb_enfant.Size = new System.Drawing.Size(133, 21);
            this.cb_enfant.TabIndex = 15;
            this.cb_enfant.SelectedIndexChanged += new System.EventHandler(this.cb_enfant_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "ENFANTS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(237, 265);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(88, 32);
            this.btn_supprimer.TabIndex = 7;
            this.btn_supprimer.Text = "SUPPRIMER";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Visible = false;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // Fen_GestionEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 313);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.panelGestionEnfants);
            this.Controls.Add(this.panelGestionEmploye);
            this.Controls.Add(this.btnValider);
            this.Name = "Fen_GestionEmploye";
            this.Text = "Fen_GestionEmploye";
            this.Load += new System.EventHandler(this.Fen_GestionEmploye_Load);
            this.panelGestionEmploye.ResumeLayout(false);
            this.panelGestionEmploye.PerformLayout();
            this.panelGestionEnfants.ResumeLayout(false);
            this.panelGestionEnfants.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Panel panelGestionEmploye;
        private System.Windows.Forms.Label lblEmploy;
        private System.Windows.Forms.TextBox txt_cp;
        private System.Windows.Forms.Label lblCp;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.Panel panelGestionEnfants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nomE;
        private System.Windows.Forms.Label lblNomE;
        private System.Windows.Forms.Label lblPrenomE;
        private System.Windows.Forms.TextBox txt_prenomE;
        private System.Windows.Forms.ComboBox cb_enfant;
        private System.Windows.Forms.TextBox txt_ageE;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btn_supprimer;
    }
}