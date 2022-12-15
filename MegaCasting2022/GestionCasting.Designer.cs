namespace MegaCasting2022
{
    partial class GestionCasting
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
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxCasting = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelReference = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxIntitule = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerDebutPubli = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownDureeDiff = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerDebutContrat = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownNbrPoste = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxDescPoste = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxDescProfil = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBoxVerif = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxFax = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxWeb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxAdrPostale = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.listBoxSexes = new System.Windows.Forms.ListBox();
            this.listBoxTypesContrat = new System.Windows.Forms.ListBox();
            this.listBoxMetiers = new System.Windows.Forms.ListBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxLocalisation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDureeDiff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNbrPoste)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(186, 603);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(120, 55);
            this.buttonDelete.TabIndex = 43;
            this.buttonDelete.Text = "Supprimer";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.DeleteCasting);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(522, 603);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 55);
            this.button2.TabIndex = 42;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.UpdateCasting);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 603);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 55);
            this.button1.TabIndex = 41;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddCasting);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(79, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 35);
            this.label2.TabIndex = 40;
            this.label2.Text = "Castings";
            // 
            // listBoxCasting
            // 
            this.listBoxCasting.FormattingEnabled = true;
            this.listBoxCasting.ItemHeight = 20;
            this.listBoxCasting.Location = new System.Drawing.Point(24, 40);
            this.listBoxCasting.Name = "listBoxCasting";
            this.listBoxCasting.Size = new System.Drawing.Size(254, 524);
            this.listBoxCasting.TabIndex = 39;
            this.listBoxCasting.SelectedIndexChanged += new System.EventHandler(this.UpdateCastingInfo);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Identifiant :";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(439, 27);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(45, 20);
            this.labelId.TabIndex = 45;
            this.labelId.Text = "None";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Référence :";
            // 
            // labelReference
            // 
            this.labelReference.AutoSize = true;
            this.labelReference.Location = new System.Drawing.Point(578, 27);
            this.labelReference.Name = "labelReference";
            this.labelReference.Size = new System.Drawing.Size(45, 20);
            this.labelReference.TabIndex = 47;
            this.labelReference.Text = "None";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Intitulé :";
            // 
            // textBoxIntitule
            // 
            this.textBoxIntitule.Location = new System.Drawing.Point(451, 59);
            this.textBoxIntitule.Name = "textBoxIntitule";
            this.textBoxIntitule.Size = new System.Drawing.Size(194, 27);
            this.textBoxIntitule.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Date début publication :";
            // 
            // dateTimePickerDebutPubli
            // 
            this.dateTimePickerDebutPubli.Location = new System.Drawing.Point(556, 105);
            this.dateTimePickerDebutPubli.Name = "dateTimePickerDebutPubli";
            this.dateTimePickerDebutPubli.Size = new System.Drawing.Size(232, 27);
            this.dateTimePickerDebutPubli.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 20);
            this.label8.TabIndex = 52;
            this.label8.Text = "Durée diffusion (en heures) :";
            // 
            // numericUpDownDureeDiff
            // 
            this.numericUpDownDureeDiff.Location = new System.Drawing.Point(566, 197);
            this.numericUpDownDureeDiff.Name = "numericUpDownDureeDiff";
            this.numericUpDownDureeDiff.Size = new System.Drawing.Size(60, 27);
            this.numericUpDownDureeDiff.TabIndex = 53;
            // 
            // dateTimePickerDebutContrat
            // 
            this.dateTimePickerDebutContrat.Location = new System.Drawing.Point(556, 152);
            this.dateTimePickerDebutContrat.Name = "dateTimePickerDebutContrat";
            this.dateTimePickerDebutContrat.Size = new System.Drawing.Size(232, 27);
            this.dateTimePickerDebutContrat.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(371, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 20);
            this.label9.TabIndex = 54;
            this.label9.Text = "Date début contrat :";
            // 
            // numericUpDownNbrPoste
            // 
            this.numericUpDownNbrPoste.Location = new System.Drawing.Point(794, 197);
            this.numericUpDownNbrPoste.Name = "numericUpDownNbrPoste";
            this.numericUpDownNbrPoste.Size = new System.Drawing.Size(60, 27);
            this.numericUpDownNbrPoste.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(649, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 20);
            this.label10.TabIndex = 56;
            this.label10.Text = "Nombre de postes :";
            // 
            // textBoxDescPoste
            // 
            this.textBoxDescPoste.Location = new System.Drawing.Point(548, 239);
            this.textBoxDescPoste.Name = "textBoxDescPoste";
            this.textBoxDescPoste.Size = new System.Drawing.Size(282, 27);
            this.textBoxDescPoste.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(380, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 20);
            this.label11.TabIndex = 58;
            this.label11.Text = "Description poste :";
            // 
            // textBoxDescProfil
            // 
            this.textBoxDescProfil.Location = new System.Drawing.Point(548, 272);
            this.textBoxDescProfil.Name = "textBoxDescProfil";
            this.textBoxDescProfil.Size = new System.Drawing.Size(282, 27);
            this.textBoxDescProfil.TabIndex = 61;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(381, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 20);
            this.label12.TabIndex = 60;
            this.label12.Text = "Description profil :";
            // 
            // checkBoxVerif
            // 
            this.checkBoxVerif.AutoSize = true;
            this.checkBoxVerif.Location = new System.Drawing.Point(779, 62);
            this.checkBoxVerif.Name = "checkBoxVerif";
            this.checkBoxVerif.Size = new System.Drawing.Size(18, 17);
            this.checkBoxVerif.TabIndex = 63;
            this.checkBoxVerif.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(692, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 20);
            this.label13.TabIndex = 62;
            this.label13.Text = "Vérifié :";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(566, 305);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(114, 27);
            this.textBoxPhone.TabIndex = 69;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(475, 308);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 20);
            this.label16.TabIndex = 68;
            this.label16.Text = "Téléphone :";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(346, 305);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(114, 27);
            this.textBoxEmail.TabIndex = 71;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(287, 308);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 20);
            this.label15.TabIndex = 70;
            this.label15.Text = "Email :";
            // 
            // textBoxFax
            // 
            this.textBoxFax.Location = new System.Drawing.Point(731, 305);
            this.textBoxFax.Name = "textBoxFax";
            this.textBoxFax.Size = new System.Drawing.Size(114, 27);
            this.textBoxFax.TabIndex = 73;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(688, 308);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 20);
            this.label17.TabIndex = 72;
            this.label17.Text = "Fax :";
            // 
            // textBoxWeb
            // 
            this.textBoxWeb.Location = new System.Drawing.Point(368, 354);
            this.textBoxWeb.Name = "textBoxWeb";
            this.textBoxWeb.Size = new System.Drawing.Size(141, 27);
            this.textBoxWeb.TabIndex = 77;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(287, 357);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 20);
            this.label14.TabIndex = 76;
            this.label14.Text = "Site Web :";
            // 
            // textBoxAdrPostale
            // 
            this.textBoxAdrPostale.Location = new System.Drawing.Point(645, 354);
            this.textBoxAdrPostale.Name = "textBoxAdrPostale";
            this.textBoxAdrPostale.Size = new System.Drawing.Size(181, 27);
            this.textBoxAdrPostale.TabIndex = 75;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(520, 357);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 20);
            this.label18.TabIndex = 74;
            this.label18.Text = "Adresse Postale :";
            // 
            // listBoxSexes
            // 
            this.listBoxSexes.FormattingEnabled = true;
            this.listBoxSexes.ItemHeight = 20;
            this.listBoxSexes.Location = new System.Drawing.Point(451, 432);
            this.listBoxSexes.Name = "listBoxSexes";
            this.listBoxSexes.Size = new System.Drawing.Size(210, 44);
            this.listBoxSexes.TabIndex = 78;
            // 
            // listBoxTypesContrat
            // 
            this.listBoxTypesContrat.FormattingEnabled = true;
            this.listBoxTypesContrat.ItemHeight = 20;
            this.listBoxTypesContrat.Location = new System.Drawing.Point(451, 482);
            this.listBoxTypesContrat.Name = "listBoxTypesContrat";
            this.listBoxTypesContrat.Size = new System.Drawing.Size(210, 44);
            this.listBoxTypesContrat.TabIndex = 79;
            // 
            // listBoxMetiers
            // 
            this.listBoxMetiers.FormattingEnabled = true;
            this.listBoxMetiers.ItemHeight = 20;
            this.listBoxMetiers.Location = new System.Drawing.Point(451, 532);
            this.listBoxMetiers.Name = "listBoxMetiers";
            this.listBoxMetiers.Size = new System.Drawing.Size(210, 44);
            this.listBoxMetiers.TabIndex = 80;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(391, 444);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 20);
            this.label19.TabIndex = 81;
            this.label19.Text = "Sexes :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(320, 494);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(125, 20);
            this.label20.TabIndex = 82;
            this.label20.Text = "Types de contrat :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(379, 544);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 20);
            this.label21.TabIndex = 83;
            this.label21.Text = "Métiers :";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(687, 432);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 44);
            this.button3.TabIndex = 84;
            this.button3.Text = "Configurer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ConfigSexes);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(688, 532);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 44);
            this.button4.TabIndex = 85;
            this.button4.Text = "Configurer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ConfigMetiers);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(688, 482);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 44);
            this.button5.TabIndex = 86;
            this.button5.Text = "Configurer";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ConfigTypeContrat);
            // 
            // textBoxLocalisation
            // 
            this.textBoxLocalisation.Location = new System.Drawing.Point(388, 399);
            this.textBoxLocalisation.Name = "textBoxLocalisation";
            this.textBoxLocalisation.Size = new System.Drawing.Size(141, 27);
            this.textBoxLocalisation.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 87;
            this.label3.Text = "Localisation :";
            // 
            // GestionCasting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxLocalisation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.listBoxMetiers);
            this.Controls.Add(this.listBoxTypesContrat);
            this.Controls.Add(this.listBoxSexes);
            this.Controls.Add(this.textBoxWeb);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxAdrPostale);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBoxFax);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.checkBoxVerif);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxDescProfil);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxDescPoste);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericUpDownNbrPoste);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePickerDebutContrat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDownDureeDiff);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePickerDebutPubli);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxIntitule);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelReference);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxCasting);
            this.Name = "GestionCasting";
            this.Size = new System.Drawing.Size(866, 672);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDureeDiff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNbrPoste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonDelete;
        private Button button2;
        private Button button1;
        private Label label2;
        private ListBox listBoxCasting;
        private Label label1;
        private Label labelId;
        private Label label4;
        private Label labelReference;
        private Label label6;
        private TextBox textBoxIntitule;
        private Label label7;
        private DateTimePicker dateTimePickerDebutPubli;
        private Label label8;
        private NumericUpDown numericUpDownDureeDiff;
        private DateTimePicker dateTimePickerDebutContrat;
        private Label label9;
        private NumericUpDown numericUpDownNbrPoste;
        private Label label10;
        private TextBox textBoxDescPoste;
        private Label label11;
        private TextBox textBoxDescProfil;
        private Label label12;
        private CheckBox checkBoxVerif;
        private Label label13;
        private TextBox textBoxPhone;
        private Label label16;
        private TextBox textBoxEmail;
        private Label label15;
        private TextBox textBoxFax;
        private Label label17;
        private TextBox textBoxWeb;
        private Label label14;
        private TextBox textBoxAdrPostale;
        private Label label18;
        private ListBox listBoxSexes;
        private ListBox listBoxTypesContrat;
        private ListBox listBoxMetiers;
        private Label label19;
        private Label label20;
        private Label label21;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBoxLocalisation;
        private Label label3;
    }
}
