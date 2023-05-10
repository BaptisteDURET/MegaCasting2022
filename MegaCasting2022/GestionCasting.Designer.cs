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
            buttonDelete = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            listBoxCasting = new ListBox();
            label1 = new Label();
            labelId = new Label();
            label4 = new Label();
            labelReference = new Label();
            label6 = new Label();
            textBoxIntitule = new TextBox();
            label7 = new Label();
            dateTimePickerDebutPubli = new DateTimePicker();
            label8 = new Label();
            numericUpDownDureeDiff = new NumericUpDown();
            dateTimePickerDebutContrat = new DateTimePicker();
            label9 = new Label();
            numericUpDownNbrPoste = new NumericUpDown();
            label10 = new Label();
            textBoxDescPoste = new TextBox();
            label11 = new Label();
            textBoxDescProfil = new TextBox();
            label12 = new Label();
            checkBoxVerif = new CheckBox();
            label13 = new Label();
            textBoxPhone = new TextBox();
            label16 = new Label();
            textBoxEmail = new TextBox();
            label15 = new Label();
            textBoxFax = new TextBox();
            label17 = new Label();
            textBoxWeb = new TextBox();
            label14 = new Label();
            textBoxAdrPostale = new TextBox();
            label18 = new Label();
            textBoxLocalisation = new TextBox();
            label3 = new Label();
            textBoxSearch = new TextBox();
            label5 = new Label();
            comboBoxMetier = new ComboBox();
            comboBoxTypeContrat = new ComboBox();
            comboBoxSexe = new ComboBox();
            label19 = new Label();
            label21 = new Label();
            label20 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDureeDiff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNbrPoste).BeginInit();
            SuspendLayout();
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(186, 603);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(120, 55);
            buttonDelete.TabIndex = 43;
            buttonDelete.Text = "Supprimer";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += DeleteCasting;
            // 
            // button2
            // 
            button2.Location = new Point(522, 603);
            button2.Name = "button2";
            button2.Size = new Size(148, 55);
            button2.TabIndex = 42;
            button2.Text = "Modifier";
            button2.UseVisualStyleBackColor = true;
            button2.Click += UpdateCasting;
            // 
            // button1
            // 
            button1.Location = new Point(24, 603);
            button1.Name = "button1";
            button1.Size = new Size(120, 55);
            button1.TabIndex = 41;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddCasting;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(79, 2);
            label2.Name = "label2";
            label2.Size = new Size(108, 35);
            label2.TabIndex = 40;
            label2.Text = "Castings";
            // 
            // listBoxCasting
            // 
            listBoxCasting.FormattingEnabled = true;
            listBoxCasting.ItemHeight = 20;
            listBoxCasting.Location = new Point(24, 120);
            listBoxCasting.Name = "listBoxCasting";
            listBoxCasting.Size = new Size(254, 444);
            listBoxCasting.TabIndex = 39;
            listBoxCasting.SelectedIndexChanged += UpdateCastingInfo;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(349, 27);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 44;
            label1.Text = "Identifiant :";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(439, 27);
            labelId.Name = "labelId";
            labelId.Size = new Size(45, 20);
            labelId.TabIndex = 45;
            labelId.Text = "None";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(490, 27);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 46;
            label4.Text = "Référence :";
            // 
            // labelReference
            // 
            labelReference.AutoSize = true;
            labelReference.Location = new Point(578, 27);
            labelReference.Name = "labelReference";
            labelReference.Size = new Size(45, 20);
            labelReference.TabIndex = 47;
            labelReference.Text = "None";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(349, 62);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 48;
            label6.Text = "Intitulé :";
            // 
            // textBoxIntitule
            // 
            textBoxIntitule.Location = new Point(451, 59);
            textBoxIntitule.Name = "textBoxIntitule";
            textBoxIntitule.Size = new Size(194, 27);
            textBoxIntitule.TabIndex = 49;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(343, 110);
            label7.Name = "label7";
            label7.Size = new Size(170, 20);
            label7.TabIndex = 50;
            label7.Text = "Date début publication :";
            // 
            // dateTimePickerDebutPubli
            // 
            dateTimePickerDebutPubli.Location = new Point(556, 105);
            dateTimePickerDebutPubli.Name = "dateTimePickerDebutPubli";
            dateTimePickerDebutPubli.Size = new Size(232, 27);
            dateTimePickerDebutPubli.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(331, 199);
            label8.Name = "label8";
            label8.Size = new Size(195, 20);
            label8.TabIndex = 52;
            label8.Text = "Durée diffusion (en heures) :";
            // 
            // numericUpDownDureeDiff
            // 
            numericUpDownDureeDiff.Location = new Point(566, 197);
            numericUpDownDureeDiff.Name = "numericUpDownDureeDiff";
            numericUpDownDureeDiff.Size = new Size(60, 27);
            numericUpDownDureeDiff.TabIndex = 53;
            // 
            // dateTimePickerDebutContrat
            // 
            dateTimePickerDebutContrat.Location = new Point(556, 152);
            dateTimePickerDebutContrat.Name = "dateTimePickerDebutContrat";
            dateTimePickerDebutContrat.Size = new Size(232, 27);
            dateTimePickerDebutContrat.TabIndex = 55;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(371, 159);
            label9.Name = "label9";
            label9.Size = new Size(142, 20);
            label9.TabIndex = 54;
            label9.Text = "Date début contrat :";
            // 
            // numericUpDownNbrPoste
            // 
            numericUpDownNbrPoste.Location = new Point(794, 197);
            numericUpDownNbrPoste.Name = "numericUpDownNbrPoste";
            numericUpDownNbrPoste.Size = new Size(60, 27);
            numericUpDownNbrPoste.TabIndex = 57;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(649, 199);
            label10.Name = "label10";
            label10.Size = new Size(139, 20);
            label10.TabIndex = 56;
            label10.Text = "Nombre de postes :";
            // 
            // textBoxDescPoste
            // 
            textBoxDescPoste.Location = new Point(548, 239);
            textBoxDescPoste.Name = "textBoxDescPoste";
            textBoxDescPoste.Size = new Size(282, 27);
            textBoxDescPoste.TabIndex = 59;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(380, 242);
            label11.Name = "label11";
            label11.Size = new Size(133, 20);
            label11.TabIndex = 58;
            label11.Text = "Description poste :";
            // 
            // textBoxDescProfil
            // 
            textBoxDescProfil.Location = new Point(548, 272);
            textBoxDescProfil.Name = "textBoxDescProfil";
            textBoxDescProfil.Size = new Size(282, 27);
            textBoxDescProfil.TabIndex = 61;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(381, 275);
            label12.Name = "label12";
            label12.Size = new Size(132, 20);
            label12.TabIndex = 60;
            label12.Text = "Description profil :";
            // 
            // checkBoxVerif
            // 
            checkBoxVerif.AutoSize = true;
            checkBoxVerif.Location = new Point(779, 62);
            checkBoxVerif.Name = "checkBoxVerif";
            checkBoxVerif.Size = new Size(18, 17);
            checkBoxVerif.TabIndex = 63;
            checkBoxVerif.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(692, 59);
            label13.Name = "label13";
            label13.Size = new Size(58, 20);
            label13.TabIndex = 62;
            label13.Text = "Vérifié :";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(566, 305);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(114, 27);
            textBoxPhone.TabIndex = 69;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(475, 308);
            label16.Name = "label16";
            label16.Size = new Size(85, 20);
            label16.TabIndex = 68;
            label16.Text = "Téléphone :";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(346, 305);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(114, 27);
            textBoxEmail.TabIndex = 71;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(287, 308);
            label15.Name = "label15";
            label15.Size = new Size(53, 20);
            label15.TabIndex = 70;
            label15.Text = "Email :";
            // 
            // textBoxFax
            // 
            textBoxFax.Location = new Point(731, 305);
            textBoxFax.Name = "textBoxFax";
            textBoxFax.Size = new Size(114, 27);
            textBoxFax.TabIndex = 73;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(688, 308);
            label17.Name = "label17";
            label17.Size = new Size(37, 20);
            label17.TabIndex = 72;
            label17.Text = "Fax :";
            // 
            // textBoxWeb
            // 
            textBoxWeb.Location = new Point(368, 354);
            textBoxWeb.Name = "textBoxWeb";
            textBoxWeb.Size = new Size(141, 27);
            textBoxWeb.TabIndex = 77;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(287, 357);
            label14.Name = "label14";
            label14.Size = new Size(75, 20);
            label14.TabIndex = 76;
            label14.Text = "Site Web :";
            // 
            // textBoxAdrPostale
            // 
            textBoxAdrPostale.Location = new Point(645, 354);
            textBoxAdrPostale.Name = "textBoxAdrPostale";
            textBoxAdrPostale.Size = new Size(181, 27);
            textBoxAdrPostale.TabIndex = 75;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(520, 357);
            label18.Name = "label18";
            label18.Size = new Size(119, 20);
            label18.TabIndex = 74;
            label18.Text = "Adresse Postale :";
            // 
            // textBoxLocalisation
            // 
            textBoxLocalisation.Location = new Point(388, 399);
            textBoxLocalisation.Name = "textBoxLocalisation";
            textBoxLocalisation.Size = new Size(141, 27);
            textBoxLocalisation.TabIndex = 88;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(287, 402);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 87;
            label3.Text = "Localisation :";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(93, 63);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(184, 27);
            textBoxSearch.TabIndex = 89;
            textBoxSearch.TextChanged += SearchCastings;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 66);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 90;
            label5.Text = "Recherche :";
            // 
            // comboBoxMetier
            // 
            comboBoxMetier.FormattingEnabled = true;
            comboBoxMetier.Location = new Point(675, 459);
            comboBoxMetier.Name = "comboBoxMetier";
            comboBoxMetier.Size = new Size(151, 28);
            comboBoxMetier.TabIndex = 138;
            // 
            // comboBoxTypeContrat
            // 
            comboBoxTypeContrat.FormattingEnabled = true;
            comboBoxTypeContrat.Location = new Point(703, 398);
            comboBoxTypeContrat.Name = "comboBoxTypeContrat";
            comboBoxTypeContrat.Size = new Size(151, 28);
            comboBoxTypeContrat.TabIndex = 137;
            // 
            // comboBoxSexe
            // 
            comboBoxSexe.FormattingEnabled = true;
            comboBoxSexe.Location = new Point(392, 459);
            comboBoxSexe.Name = "comboBoxSexe";
            comboBoxSexe.Size = new Size(151, 28);
            comboBoxSexe.TabIndex = 136;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(315, 462);
            label19.Name = "label19";
            label19.Size = new Size(47, 20);
            label19.TabIndex = 135;
            label19.Text = "Sexe :";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(578, 462);
            label21.Name = "label21";
            label21.Size = new Size(59, 20);
            label21.TabIndex = 134;
            label21.Text = "Métier :";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(541, 401);
            label20.Name = "label20";
            label20.Size = new Size(125, 20);
            label20.TabIndex = 133;
            label20.Text = "Types de contrat :";
            // 
            // GestionCasting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBoxMetier);
            Controls.Add(comboBoxTypeContrat);
            Controls.Add(comboBoxSexe);
            Controls.Add(label19);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label5);
            Controls.Add(textBoxSearch);
            Controls.Add(textBoxLocalisation);
            Controls.Add(label3);
            Controls.Add(textBoxWeb);
            Controls.Add(label14);
            Controls.Add(textBoxAdrPostale);
            Controls.Add(label18);
            Controls.Add(textBoxFax);
            Controls.Add(label17);
            Controls.Add(textBoxEmail);
            Controls.Add(label15);
            Controls.Add(textBoxPhone);
            Controls.Add(label16);
            Controls.Add(checkBoxVerif);
            Controls.Add(label13);
            Controls.Add(textBoxDescProfil);
            Controls.Add(label12);
            Controls.Add(textBoxDescPoste);
            Controls.Add(label11);
            Controls.Add(numericUpDownNbrPoste);
            Controls.Add(label10);
            Controls.Add(dateTimePickerDebutContrat);
            Controls.Add(label9);
            Controls.Add(numericUpDownDureeDiff);
            Controls.Add(label8);
            Controls.Add(dateTimePickerDebutPubli);
            Controls.Add(label7);
            Controls.Add(textBoxIntitule);
            Controls.Add(label6);
            Controls.Add(labelReference);
            Controls.Add(label4);
            Controls.Add(labelId);
            Controls.Add(label1);
            Controls.Add(buttonDelete);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(listBoxCasting);
            Name = "GestionCasting";
            Size = new Size(866, 672);
            ((System.ComponentModel.ISupportInitialize)numericUpDownDureeDiff).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNbrPoste).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox textBoxLocalisation;
        private Label label3;
        private TextBox textBoxSearch;
        private Label label5;
        private ComboBox comboBoxMetier;
        private ComboBox comboBoxTypeContrat;
        private ComboBox comboBoxSexe;
        private Label label19;
        private Label label21;
        private Label label20;
    }
}
