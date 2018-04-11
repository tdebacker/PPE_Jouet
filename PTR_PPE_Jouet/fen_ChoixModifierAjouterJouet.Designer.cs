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
            this.btn_ValiderChoix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_NumEnfant
            // 
            this.lbl_NumEnfant.AutoSize = true;
            this.lbl_NumEnfant.Location = new System.Drawing.Point(193, 31);
            this.lbl_NumEnfant.Name = "lbl_NumEnfant";
            this.lbl_NumEnfant.Size = new System.Drawing.Size(57, 13);
            this.lbl_NumEnfant.TabIndex = 0;
            this.lbl_NumEnfant.Text = "Enfant n° :";
            this.lbl_NumEnfant.Click += new System.EventHandler(this.lbl_NumEnfant_Click);
            // 
            // cb_jouet
            // 
            this.cb_jouet.FormattingEnabled = true;
            this.cb_jouet.Location = new System.Drawing.Point(210, 119);
            this.cb_jouet.Name = "cb_jouet";
            this.cb_jouet.Size = new System.Drawing.Size(213, 21);
            this.cb_jouet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste des Jouets :";
            // 
            // btn_ValiderChoix
            // 
            this.btn_ValiderChoix.Location = new System.Drawing.Point(232, 250);
            this.btn_ValiderChoix.Name = "btn_ValiderChoix";
            this.btn_ValiderChoix.Size = new System.Drawing.Size(144, 31);
            this.btn_ValiderChoix.TabIndex = 3;
            this.btn_ValiderChoix.Text = "Valider";
            this.btn_ValiderChoix.UseVisualStyleBackColor = true;
            this.btn_ValiderChoix.Click += new System.EventHandler(this.btn_ValiderChoix_Click);
            // 
            // fen_ChoixModifierAjouterJouet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 377);
            this.Controls.Add(this.btn_ValiderChoix);
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
        private System.Windows.Forms.Button btn_ValiderChoix;
    }
}