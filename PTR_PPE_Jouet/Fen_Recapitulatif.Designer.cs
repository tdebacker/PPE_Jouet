namespace PTR_PPE_Jouet
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
            this.Lbl_recap = new System.Windows.Forms.Label();
            this.Txt_nbJouetTotal = new System.Windows.Forms.TextBox();
            this.Lbl_NbtotalJ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_recap
            // 
            this.Lbl_recap.AutoSize = true;
            this.Lbl_recap.Location = new System.Drawing.Point(12, 9);
            this.Lbl_recap.Name = "Lbl_recap";
            this.Lbl_recap.Size = new System.Drawing.Size(96, 13);
            this.Lbl_recap.TabIndex = 0;
            this.Lbl_recap.Text = "RECAPITULATIF :";
            // 
            // Txt_nbJouetTotal
            // 
            this.Txt_nbJouetTotal.Location = new System.Drawing.Point(143, 48);
            this.Txt_nbJouetTotal.Name = "Txt_nbJouetTotal";
            this.Txt_nbJouetTotal.ReadOnly = true;
            this.Txt_nbJouetTotal.Size = new System.Drawing.Size(32, 20);
            this.Txt_nbJouetTotal.TabIndex = 1;
            this.Txt_nbJouetTotal.TabStop = false;
            // 
            // Lbl_NbtotalJ
            // 
            this.Lbl_NbtotalJ.AutoSize = true;
            this.Lbl_NbtotalJ.Location = new System.Drawing.Point(92, 51);
            this.Lbl_NbtotalJ.Name = "Lbl_NbtotalJ";
            this.Lbl_NbtotalJ.Size = new System.Drawing.Size(45, 13);
            this.Lbl_NbtotalJ.TabIndex = 2;
            this.Lbl_NbtotalJ.Text = "TOTAL ";
            // 
            // Fen_Recapitulatif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 334);
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

        private System.Windows.Forms.Label Lbl_recap;
        private System.Windows.Forms.TextBox Txt_nbJouetTotal;
        private System.Windows.Forms.Label Lbl_NbtotalJ;
    }
}