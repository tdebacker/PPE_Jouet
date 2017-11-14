namespace PTR_PPE_Jouet
{
    partial class fen_ChoixModifierAjouterJouet
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
            this.lbl_NumEnfant = new System.Windows.Forms.Label();
            this.cb_jouet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_infosJouet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_NumEnfant
            // 
            this.lbl_NumEnfant.AutoSize = true;
            this.lbl_NumEnfant.Location = new System.Drawing.Point(56, 32);
            this.lbl_NumEnfant.Name = "lbl_NumEnfant";
            this.lbl_NumEnfant.Size = new System.Drawing.Size(57, 13);
            this.lbl_NumEnfant.TabIndex = 0;
            this.lbl_NumEnfant.Text = "Enfant n° :";
            // 
            // cb_jouet
            // 
            this.cb_jouet.FormattingEnabled = true;
            this.cb_jouet.Location = new System.Drawing.Point(151, 111);
            this.cb_jouet.Name = "cb_jouet";
            this.cb_jouet.Size = new System.Drawing.Size(600, 21);
            this.cb_jouet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste des Jouets :";
            // 
            // lbl_infosJouet
            // 
            this.lbl_infosJouet.AutoSize = true;
            this.lbl_infosJouet.Location = new System.Drawing.Point(59, 205);
            this.lbl_infosJouet.Name = "lbl_infosJouet";
            this.lbl_infosJouet.Size = new System.Drawing.Size(114, 13);
            this.lbl_infosJouet.TabIndex = 3;
            this.lbl_infosJouet.Text = "Informations du Jouet :";
            // 
            // fen_ChoixModifierAjouterJouet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 477);
            this.Controls.Add(this.lbl_infosJouet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_jouet);
            this.Controls.Add(this.lbl_NumEnfant);
            this.Name = "fen_ChoixModifierAjouterJouet";
            this.Text = "Choix du Jouet";
            this.Load += new System.EventHandler(this.fen_ChoixModifierAjouterJouet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NumEnfant;
        private System.Windows.Forms.ComboBox cb_jouet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_infosJouet;
    }
}