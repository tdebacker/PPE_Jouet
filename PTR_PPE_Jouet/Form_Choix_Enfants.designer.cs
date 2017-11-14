namespace PTR_PPE_Jouet
{
    partial class Form_Choix_Enfants
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
            this.lbl_vosEnfants = new System.Windows.Forms.Label();
            this.cb_enfant = new System.Windows.Forms.ComboBox();
            this.lbl_jouetCorrespondant = new System.Windows.Forms.Label();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_cloturer = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_vosEnfants
            // 
            this.lbl_vosEnfants.AutoSize = true;
            this.lbl_vosEnfants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vosEnfants.Location = new System.Drawing.Point(330, 97);
            this.lbl_vosEnfants.Name = "lbl_vosEnfants";
            this.lbl_vosEnfants.Size = new System.Drawing.Size(111, 20);
            this.lbl_vosEnfants.TabIndex = 0;
            this.lbl_vosEnfants.Text = "Vos enfants:";
            // 
            // cb_enfant
            // 
            this.cb_enfant.FormattingEnabled = true;
            this.cb_enfant.Location = new System.Drawing.Point(148, 210);
            this.cb_enfant.Name = "cb_enfant";
            this.cb_enfant.Size = new System.Drawing.Size(133, 21);
            this.cb_enfant.TabIndex = 1;
            // 
            // lbl_jouetCorrespondant
            // 
            this.lbl_jouetCorrespondant.AutoSize = true;
            this.lbl_jouetCorrespondant.Location = new System.Drawing.Point(377, 210);
            this.lbl_jouetCorrespondant.Name = "lbl_jouetCorrespondant";
            this.lbl_jouetCorrespondant.Size = new System.Drawing.Size(101, 13);
            this.lbl_jouetCorrespondant.TabIndex = 2;
            this.lbl_jouetCorrespondant.Text = "jouet correspondant";
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(560, 206);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(124, 24);
            this.btn_modifier.TabIndex = 3;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(716, 207);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(106, 23);
            this.btn_ajouter.TabIndex = 4;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            // 
            // btn_cloturer
            // 
            this.btn_cloturer.Location = new System.Drawing.Point(188, 398);
            this.btn_cloturer.Name = "btn_cloturer";
            this.btn_cloturer.Size = new System.Drawing.Size(128, 33);
            this.btn_cloturer.TabIndex = 5;
            this.btn_cloturer.Text = "Cloturer";
            this.btn_cloturer.UseVisualStyleBackColor = true;
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(577, 398);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(126, 32);
            this.btnDeconnexion.TabIndex = 6;
            this.btnDeconnexion.Text = "Se déconnecter";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            // 
            // Form_Choix_Enfants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 579);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btn_cloturer);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.lbl_jouetCorrespondant);
            this.Controls.Add(this.cb_enfant);
            this.Controls.Add(this.lbl_vosEnfants);
            this.Name = "Form_Choix_Enfants";
            this.Text = "Form_Choix_Enfants";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_vosEnfants;
        private System.Windows.Forms.ComboBox cb_enfant;
        private System.Windows.Forms.Label lbl_jouetCorrespondant;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_cloturer;
        private System.Windows.Forms.Button btnDeconnexion;
    }
}