﻿namespace PTR_PPE_Jouet
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
            this.btn_modifierAjouter = new System.Windows.Forms.Button();
            this.btn_cloturer = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_vosEnfants
            // 
            this.lbl_vosEnfants.AutoSize = true;
            this.lbl_vosEnfants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vosEnfants.Location = new System.Drawing.Point(386, 97);
            this.lbl_vosEnfants.Name = "lbl_vosEnfants";
            this.lbl_vosEnfants.Size = new System.Drawing.Size(111, 20);
            this.lbl_vosEnfants.TabIndex = 0;
            this.lbl_vosEnfants.Text = "Vos enfants:";
            // 
            // cb_enfant
            // 
            this.cb_enfant.FormattingEnabled = true;
            this.cb_enfant.Location = new System.Drawing.Point(167, 210);
            this.cb_enfant.Name = "cb_enfant";
            this.cb_enfant.Size = new System.Drawing.Size(133, 21);
            this.cb_enfant.TabIndex = 1;
            this.cb_enfant.SelectedIndexChanged += new System.EventHandler(this.cb_enfant_SelectedIndexChanged);
            // 
            // lbl_jouetCorrespondant
            // 
            this.lbl_jouetCorrespondant.AutoSize = true;
            this.lbl_jouetCorrespondant.Location = new System.Drawing.Point(396, 210);
            this.lbl_jouetCorrespondant.Name = "lbl_jouetCorrespondant";
            this.lbl_jouetCorrespondant.Size = new System.Drawing.Size(0, 13);
            this.lbl_jouetCorrespondant.TabIndex = 2;
            // 
            // btn_modifierAjouter
            // 
            this.btn_modifierAjouter.Location = new System.Drawing.Point(579, 206);
            this.btn_modifierAjouter.Name = "btn_modifierAjouter";
            this.btn_modifierAjouter.Size = new System.Drawing.Size(124, 24);
            this.btn_modifierAjouter.TabIndex = 3;
            this.btn_modifierAjouter.Text = "Modifier/Ajouter";
            this.btn_modifierAjouter.UseVisualStyleBackColor = true;
            this.btn_modifierAjouter.Click += new System.EventHandler(this.btn_modifierAjouter_Click);
            // 
            // btn_cloturer
            // 
            this.btn_cloturer.Location = new System.Drawing.Point(515, 397);
            this.btn_cloturer.Name = "btn_cloturer";
            this.btn_cloturer.Size = new System.Drawing.Size(128, 33);
            this.btn_cloturer.TabIndex = 5;
            this.btn_cloturer.Text = "Cloturer";
            this.btn_cloturer.UseVisualStyleBackColor = true;
            this.btn_cloturer.Click += new System.EventHandler(this.btn_cloturer_Click);
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(250, 397);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(126, 33);
            this.btnDeconnexion.TabIndex = 6;
            this.btnDeconnexion.Text = "Se déconnecter";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // Form_Choix_Enfants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 579);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btn_cloturer);
            this.Controls.Add(this.btn_modifierAjouter);
            this.Controls.Add(this.lbl_jouetCorrespondant);
            this.Controls.Add(this.cb_enfant);
            this.Controls.Add(this.lbl_vosEnfants);
            this.Name = "Form_Choix_Enfants";
            this.Text = "Form_Choix_Enfants";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Choix_Enfants_FormClosing);
            this.Load += new System.EventHandler(this.Form_Choix_Enfants_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_vosEnfants;
        private System.Windows.Forms.ComboBox cb_enfant;
        private System.Windows.Forms.Label lbl_jouetCorrespondant;
        private System.Windows.Forms.Button btn_modifierAjouter;
        private System.Windows.Forms.Button btn_cloturer;
        private System.Windows.Forms.Button btnDeconnexion;
    }
}