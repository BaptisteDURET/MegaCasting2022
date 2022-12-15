namespace MegaCasting2022
{
    partial class GestionPartenaire
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDelete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxVerif = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxEntreprise = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxPartenaire = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(694, 591);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(148, 55);
            this.buttonDelete.TabIndex = 38;
            this.buttonDelete.Text = "Supprimer";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.DeletePartenaire);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(518, 591);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 55);
            this.button2.TabIndex = 37;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.UpdatePartenaire);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 591);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 55);
            this.button1.TabIndex = 36;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddPartenaire);
            // 
            // checkBoxVerif
            // 
            this.checkBoxVerif.AutoSize = true;
            this.checkBoxVerif.Location = new System.Drawing.Point(518, 464);
            this.checkBoxVerif.Name = "checkBoxVerif";
            this.checkBoxVerif.Size = new System.Drawing.Size(18, 17);
            this.checkBoxVerif.TabIndex = 35;
            this.checkBoxVerif.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(431, 464);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Vérifié :";
            // 
            // textBoxEntreprise
            // 
            this.textBoxEntreprise.Location = new System.Drawing.Point(518, 382);
            this.textBoxEntreprise.Name = "textBoxEntreprise";
            this.textBoxEntreprise.Size = new System.Drawing.Size(126, 27);
            this.textBoxEntreprise.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Entreprise :";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(518, 308);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(126, 27);
            this.textBoxEmail.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Email :";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(518, 226);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(126, 27);
            this.textBoxPhone.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Numéro de téléphone :";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(518, 158);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(126, 27);
            this.textBoxUsername.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Nom utilisateur :";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(518, 82);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(45, 20);
            this.labelId.TabIndex = 25;
            this.labelId.Text = "None";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Identifiant :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(86, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 35);
            this.label2.TabIndex = 23;
            this.label2.Text = "Partenaires";
            // 
            // listBoxPartenaire
            // 
            this.listBoxPartenaire.FormattingEnabled = true;
            this.listBoxPartenaire.ItemHeight = 20;
            this.listBoxPartenaire.Location = new System.Drawing.Point(24, 82);
            this.listBoxPartenaire.Name = "listBoxPartenaire";
            this.listBoxPartenaire.Size = new System.Drawing.Size(282, 564);
            this.listBoxPartenaire.TabIndex = 22;
            this.listBoxPartenaire.SelectedIndexChanged += new System.EventHandler(this.UpdatePartenaireInfo);
            // 
            // GestionPartenaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxVerif);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxEntreprise);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxPartenaire);
            this.Name = "GestionPartenaire";
            this.Size = new System.Drawing.Size(866, 672);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonDelete;
        private Button button2;
        private Button button1;
        private CheckBox checkBoxVerif;
        private Label label8;
        private TextBox textBoxEntreprise;
        private Label label7;
        private TextBox textBoxEmail;
        private Label label6;
        private TextBox textBoxPhone;
        private Label label5;
        private TextBox textBoxUsername;
        private Label label4;
        private Label labelId;
        private Label label1;
        private Label label2;
        private ListBox listBoxPartenaire;
    }
}
