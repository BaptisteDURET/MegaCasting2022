using MegaCasting2022.DBLib.Requetes;
using MegaCasting2022.DBLib.tables;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaCasting2022
{
    public partial class AddCasting : Form
    {
        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }
        public AddCasting()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            comboBoxClient.Items.Clear();
            comboBoxClient.DataSource = ProfessionnelDB.All();
            if (comboBoxClient.Items.Count > 0)
            {
                comboBoxClient.SelectedIndex = 0;
            }

            comboBoxMetier.Items.Clear();
            List<Metier> metiers = MetierDB.All();
            Metier m = new Metier();
            m.Libelle = "Aucun";
            metiers.Insert(0, m);
            comboBoxMetier.DataSource = metiers;
            if (comboBoxMetier.Items.Count > 0)
            {
                comboBoxMetier.SelectedIndex = 0;
            }

            comboBoxSexe.Items.Clear();
            List<Sexe> sexes  = SexeDB.All();
            Sexe s = new Sexe();
            s.Libelle = "Aucun";
            sexes.Insert(0, s);
            comboBoxSexe.DataSource = sexes;
            if (comboBoxSexe.Items.Count > 0)
            {
                comboBoxSexe.SelectedIndex = 0;
            }

            comboBoxTypeContrat.Items.Clear();
            comboBoxTypeContrat.DataSource = TypeContratDB.All();
            if (comboBoxTypeContrat.Items.Count > 0)
            {
                comboBoxTypeContrat.SelectedIndex = 0;
            }

            numericUpDownDureeDiff.Minimum = 1;
            numericUpDownDureeDiff.Maximum = 730;

            numericUpDownNbrPoste.Minimum = 1;
            numericUpDownNbrPoste.Maximum = 100;
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertCasting(object sender, EventArgs e)
        {
            Casting casting = new Casting();
            casting.Reference = RandomString(12) + GetTimestamp(DateTime.Now);
            casting.Verifie = checkBoxVerif.Checked;
            casting.DateDebutPublication = dateTimePickerDebutPubli.Value;
            casting.DateDebutContrat = dateTimePickerDebutContrat.Value;
            casting.DureeDiffusion = Convert.ToInt16((int)numericUpDownDureeDiff.Value);
            casting.NombrePosteDispo = Convert.ToInt16((int)numericUpDownNbrPoste.Value);
            casting.Intitule = textBoxIntitule.Text;
            casting.Description = textBoxDescPoste.Text;
            casting.DescriptionProfilRecherche = textBoxDescProfil.Text;
            casting.Email = textBoxEmail.Text;
            casting.NumeroTelephone = textBoxPhone.Text;
            casting.Fax = textBoxFax.Text;
            casting.SiteWeb = textBoxWeb.Text;
            casting.AdressePostale = textBoxAdrPostale.Text;
            casting.Localisation = textBoxLocalisation.Text;
            casting.IdentifiantProfessionnel = ((Professionnel)comboBoxClient.SelectedItem).Identifiant;

            if (((Metier)comboBoxMetier.SelectedItem).Identifiant != 0)
            {
                casting.IdentifiantMetier = ((Metier)comboBoxMetier.SelectedItem).Identifiant;
            } else
            {
                casting.IdentifiantMetier = null;
            }

            if (((Sexe)comboBoxSexe.SelectedItem).Identifiant != 0)
            {
                casting.IdentifiantSexe = ((Sexe)comboBoxSexe.SelectedItem).Identifiant;
            } else
            {
                casting.IdentifiantSexe = null;
            }

            casting.IdentifiantTypeContrat = ((TypeContrat)comboBoxTypeContrat.SelectedItem).Identifiant;
            CastingDB.Insert(casting);
            this.Close();
            this.DialogResult = DialogResult.OK;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult dialogResult = MessageBox.Show("Le casting " + casting.Intitule + " a bien été ajouté !", "Succès", buttons, MessageBoxIcon.Information);


        }

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
