namespace PTR_PPE_Jouet
{
    partial class Fen_MenuGestion
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
            this.btn_AjoutEnfant = new System.Windows.Forms.Button();
            this.btn_NouvelleEmploye = new System.Windows.Forms.Button();
            this.cb_listeEmploye = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ModifEnfant = new System.Windows.Forms.Button();
            this.lbl_Employe = new System.Windows.Forms.Label();
            this.btn_ModifEmploye = new System.Windows.Forms.Button();
            this.lbl_titre_fen_Menu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_AjoutEnfant
            // 
            this.btn_AjoutEnfant.Enabled = false;
            this.btn_AjoutEnfant.Location = new System.Drawing.Point(93, 202);
            this.btn_AjoutEnfant.Name = "btn_AjoutEnfant";
            this.btn_AjoutEnfant.Size = new System.Drawing.Size(119, 30);
            this.btn_AjoutEnfant.TabIndex = 3;
            this.btn_AjoutEnfant.Text = "Nouvel Enfant";
            this.btn_AjoutEnfant.UseVisualStyleBackColor = true;
            this.btn_AjoutEnfant.Click += new System.EventHandler(this.btn_AjoutEnfant_Click);
            // 
            // btn_NouvelleEmploye
            // 
            this.btn_NouvelleEmploye.Location = new System.Drawing.Point(93, 290);
            this.btn_NouvelleEmploye.Name = "btn_NouvelleEmploye";
            this.btn_NouvelleEmploye.Size = new System.Drawing.Size(119, 30);
            this.btn_NouvelleEmploye.TabIndex = 5;
            this.btn_NouvelleEmploye.Text = "Nouvel Employé";
            this.btn_NouvelleEmploye.UseVisualStyleBackColor = true;
            this.btn_NouvelleEmploye.Click += new System.EventHandler(this.btn_NouvelleEmploye_Click);
            // 
            // cb_listeEmploye
            // 
            this.cb_listeEmploye.FormattingEnabled = true;
            this.cb_listeEmploye.Location = new System.Drawing.Point(93, 74);
            this.cb_listeEmploye.Name = "cb_listeEmploye";
            this.cb_listeEmploye.Size = new System.Drawing.Size(119, 21);
            this.cb_listeEmploye.TabIndex = 1;
            this.cb_listeEmploye.SelectedIndexChanged += new System.EventHandler(this.cb_listeEmploye_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "__________________________";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ModifEnfant
            // 
            this.btn_ModifEnfant.Enabled = false;
            this.btn_ModifEnfant.Location = new System.Drawing.Point(93, 166);
            this.btn_ModifEnfant.Name = "btn_ModifEnfant";
            this.btn_ModifEnfant.Size = new System.Drawing.Size(119, 30);
            this.btn_ModifEnfant.TabIndex = 4;
            this.btn_ModifEnfant.Text = "Modifier Enfant";
            this.btn_ModifEnfant.UseVisualStyleBackColor = true;
            this.btn_ModifEnfant.Click += new System.EventHandler(this.btn_ModifEnfant_Click);
            // 
            // lbl_Employe
            // 
            this.lbl_Employe.AutoSize = true;
            this.lbl_Employe.Location = new System.Drawing.Point(31, 74);
            this.lbl_Employe.Name = "lbl_Employe";
            this.lbl_Employe.Size = new System.Drawing.Size(53, 13);
            this.lbl_Employe.TabIndex = 5;
            this.lbl_Employe.Text = "Employé :";
            // 
            // btn_ModifEmploye
            // 
            this.btn_ModifEmploye.Enabled = false;
            this.btn_ModifEmploye.Location = new System.Drawing.Point(93, 130);
            this.btn_ModifEmploye.Name = "btn_ModifEmploye";
            this.btn_ModifEmploye.Size = new System.Drawing.Size(119, 30);
            this.btn_ModifEmploye.TabIndex = 2;
            this.btn_ModifEmploye.Text = "Modifier Employé";
            this.btn_ModifEmploye.UseVisualStyleBackColor = true;
            this.btn_ModifEmploye.Click += new System.EventHandler(this.btn_ModifEmploye_Click);
            // 
            // lbl_titre_fen_Menu
            // 
            this.lbl_titre_fen_Menu.AutoSize = true;
            this.lbl_titre_fen_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre_fen_Menu.Location = new System.Drawing.Point(115, 9);
            this.lbl_titre_fen_Menu.Name = "lbl_titre_fen_Menu";
            this.lbl_titre_fen_Menu.Size = new System.Drawing.Size(66, 25);
            this.lbl_titre_fen_Menu.TabIndex = 7;
            this.lbl_titre_fen_Menu.Text = "Menu";
            this.lbl_titre_fen_Menu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Fen_MenuGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 339);
            this.Controls.Add(this.lbl_titre_fen_Menu);
            this.Controls.Add(this.btn_ModifEmploye);
            this.Controls.Add(this.lbl_Employe);
            this.Controls.Add(this.btn_ModifEnfant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_listeEmploye);
            this.Controls.Add(this.btn_NouvelleEmploye);
            this.Controls.Add(this.btn_AjoutEnfant);
            this.Name = "Fen_MenuGestion";
            this.Text = "Fen_MenuGestion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fen_MenuGestion_FormClosing);
            this.Load += new System.EventHandler(this.Fen_MenuGestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AjoutEnfant;
        private System.Windows.Forms.Button btn_NouvelleEmploye;
        private System.Windows.Forms.ComboBox cb_listeEmploye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ModifEnfant;
        private System.Windows.Forms.Label lbl_Employe;
        private System.Windows.Forms.Button btn_ModifEmploye;
        private System.Windows.Forms.Label lbl_titre_fen_Menu;
    }
}