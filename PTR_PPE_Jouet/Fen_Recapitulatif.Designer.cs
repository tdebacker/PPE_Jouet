﻿namespace PTR_PPE_Jouet
{
    partial class Fen_Recapitulatif
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
            this.ListV_JouetsAcom = new System.Windows.Forms.ListView();
            this.idJouet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.libelle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idCategorie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idTrancheAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Categorie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ageMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QtteAcomm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lbl_NbtotalJ = new System.Windows.Forms.Label();
            this.Txt_nbJouetTotal = new System.Windows.Forms.TextBox();
            this.Lbl_recap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListV_JouetsAcom
            // 
            this.ListV_JouetsAcom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idJouet,
            this.libelle,
            this.idCategorie,
            this.idTrancheAge,
            this.Categorie,
            this.ageMin,
            this.QtteAcomm});
            this.ListV_JouetsAcom.GridLines = true;
            this.ListV_JouetsAcom.Location = new System.Drawing.Point(15, 27);
            this.ListV_JouetsAcom.Name = "ListV_JouetsAcom";
            this.ListV_JouetsAcom.Size = new System.Drawing.Size(528, 256);
            this.ListV_JouetsAcom.TabIndex = 8;
            this.ListV_JouetsAcom.UseCompatibleStateImageBehavior = false;
            this.ListV_JouetsAcom.View = System.Windows.Forms.View.Details;
            // 
            // idJouet
            // 
            this.idJouet.Text = "N°JOUET";
            // 
            // libelle
            // 
            this.libelle.Text = "NOM";
            this.libelle.Width = 37;
            // 
            // idCategorie
            // 
            this.idCategorie.Text = "N°CATEGORIE";
            this.idCategorie.Width = 86;
            // 
            // idTrancheAge
            // 
            this.idTrancheAge.Text = "N°TRANCHE";
            this.idTrancheAge.Width = 83;
            // 
            // Categorie
            // 
            this.Categorie.Text = "CATEGORIE";
            this.Categorie.Width = 78;
            // 
            // ageMin
            // 
            this.ageMin.Text = "AGE MIN";
            // 
            // QtteAcomm
            // 
            this.QtteAcomm.Text = "QUANTITE A COM";
            this.QtteAcomm.Width = 115;
            // 
            // Lbl_NbtotalJ
            // 
            this.Lbl_NbtotalJ.AutoSize = true;
            this.Lbl_NbtotalJ.Location = new System.Drawing.Point(12, 307);
            this.Lbl_NbtotalJ.Name = "Lbl_NbtotalJ";
            this.Lbl_NbtotalJ.Size = new System.Drawing.Size(108, 13);
            this.Lbl_NbtotalJ.TabIndex = 7;
            this.Lbl_NbtotalJ.Text = "TOTAL COMMANDE";
            // 
            // Txt_nbJouetTotal
            // 
            this.Txt_nbJouetTotal.Location = new System.Drawing.Point(133, 303);
            this.Txt_nbJouetTotal.Name = "Txt_nbJouetTotal";
            this.Txt_nbJouetTotal.ReadOnly = true;
            this.Txt_nbJouetTotal.Size = new System.Drawing.Size(60, 20);
            this.Txt_nbJouetTotal.TabIndex = 6;
            this.Txt_nbJouetTotal.TabStop = false;
            // 
            // Lbl_recap
            // 
            this.Lbl_recap.AutoSize = true;
            this.Lbl_recap.Location = new System.Drawing.Point(12, 11);
            this.Lbl_recap.Name = "Lbl_recap";
            this.Lbl_recap.Size = new System.Drawing.Size(96, 13);
            this.Lbl_recap.TabIndex = 5;
            this.Lbl_recap.Text = "RECAPITULATIF :";
            // 
            // Fen_Recapitulatif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 334);
            this.Controls.Add(this.ListV_JouetsAcom);
            this.Controls.Add(this.Lbl_NbtotalJ);
            this.Controls.Add(this.Txt_nbJouetTotal);
            this.Controls.Add(this.Lbl_recap);
            this.Name = "Fen_Recapitulatif";
            this.Text = "Fen_Recapitulatif";
            this.Load += new System.EventHandler(this.auLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListV_JouetsAcom;
        private System.Windows.Forms.ColumnHeader idJouet;
        private System.Windows.Forms.ColumnHeader libelle;
        private System.Windows.Forms.ColumnHeader idCategorie;
        private System.Windows.Forms.ColumnHeader idTrancheAge;
        private System.Windows.Forms.ColumnHeader Categorie;
        private System.Windows.Forms.ColumnHeader ageMin;
        private System.Windows.Forms.ColumnHeader QtteAcomm;
        private System.Windows.Forms.Label Lbl_NbtotalJ;
        private System.Windows.Forms.TextBox Txt_nbJouetTotal;
        private System.Windows.Forms.Label Lbl_recap;

    }
}