using MegaCasting2022.DBLib.Requetes;
using MegaCasting2022.DBLib.tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MegaCasting2022
{
    public partial class GestionCasting : UserControl
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();


        public GestionCasting()
        {
            InitializeComponent();
            AllocConsole();
            comboBoxMetier.Items.Clear();
            List<Metier> metiers = MetierDB.All();
            Metier m = new Metier();
            m.Libelle = "Aucun";
            metiers.Insert(0, m);
            comboBoxMetier.DataSource = metiers;

            comboBoxSexe.Items.Clear();
            List<Sexe> sexes = SexeDB.All();
            Sexe s = new Sexe();
            s.Libelle = "Aucun";
            sexes.Insert(0, s);
            comboBoxSexe.DataSource = sexes;

            comboBoxTypeContrat.Items.Clear();
            List<TypeContrat> typeContrats = TypeContratDB.All();
            //TypeContrat tc = new TypeContrat();
            //tc.LibelleCourt = "Aucun";
            //typeContrats.Insert(0, tc);
            comboBoxTypeContrat.DataSource = typeContrats;

            InitListBoxCasting();
        }

        private void InitListBoxCasting()
        {
            listBoxCasting.Items.Clear();

            List<Casting> castings = CastingDB.All();

            foreach (Casting casting in castings)
            {
                listBoxCasting.Items.Add(casting);
            }

            if (listBoxCasting.Items.Count > 0)
            {
                listBoxCasting.SelectedIndex = 0;
            }
        }

        private void UpdateCastingInfo(object sender, EventArgs e)
        {
            if (listBoxCasting.SelectedItem != null)
            {
                Casting casting = (Casting)listBoxCasting.SelectedItem;

                checkBoxVerif.Checked = casting.Verifie;

                labelId.Text = casting.Identifiant.ToString();
                labelReference.Text = casting.Reference;


                dateTimePickerDebutPubli.Value = casting.DateDebutPublication;
                dateTimePickerDebutContrat.Value = casting.DateDebutContrat;

                numericUpDownDureeDiff.Minimum = 1;
                numericUpDownDureeDiff.Maximum = 730;
                numericUpDownDureeDiff.Value = casting.DureeDiffusion;

                numericUpDownNbrPoste.Minimum = 1;
                numericUpDownNbrPoste.Maximum = 100;
                numericUpDownNbrPoste.Value = casting.NombrePosteDispo;

                textBoxIntitule.Text = casting.Intitule;
                textBoxDescPoste.Text = casting.Description;
                textBoxDescProfil.Text = casting.DescriptionProfilRecherche;
                textBoxEmail.Text = casting.Email;
                textBoxPhone.Text = casting.NumeroTelephone;
                textBoxFax.Text = casting.Fax;
                textBoxWeb.Text = casting.SiteWeb;
                textBoxAdrPostale.Text = casting.AdressePostale;
                textBoxLocalisation.Text = casting.Localisation;

                int indexMetier = comboBoxMetier.Items.Cast<Metier>().ToList().FindIndex(a => a.Identifiant == casting.IdentifiantMetier);
                if (indexMetier == -1)
                {
                    comboBoxMetier.SelectedIndex = 0;
                }
                else
                {
                    comboBoxMetier.SelectedIndex = indexMetier;
                }

                int indexSexe = comboBoxSexe.Items.Cast<Sexe>().ToList().FindIndex(a => a.Identifiant == casting.IdentifiantSexe);
                if (indexSexe == -1)
                {
                    comboBoxSexe.SelectedIndex = 0;
                }
                else
                {
                    comboBoxSexe.SelectedIndex = indexSexe;
                }

                int indexTypeContrat = comboBoxTypeContrat.Items.Cast<TypeContrat>().ToList().FindIndex(a => a.Identifiant == casting.IdentifiantTypeContrat);
                comboBoxTypeContrat.SelectedIndex = indexTypeContrat;
            }
        }

        private void DeleteCasting(object sender, EventArgs e)
        {
            if (listBoxCasting.SelectedItems != null)
            {
                Casting casting = (Casting)listBoxCasting.SelectedItem;
                CastingDB.Delete(casting);
                InitListBoxCasting();
            }
        }

        private void UpdateCasting(object sender, EventArgs e)
        {
            if (listBoxCasting.SelectedItems != null)
            {
                Casting casting = (Casting)listBoxCasting.SelectedItem;
                if (casting.Verifie != checkBoxVerif.Checked
                    || casting.Reference != labelReference.Text
                    || casting.DateDebutPublication != dateTimePickerDebutPubli.Value
                    || casting.DateDebutContrat != dateTimePickerDebutContrat.Value
                    || casting.DureeDiffusion != numericUpDownDureeDiff.Value
                    || casting.NombrePosteDispo != numericUpDownNbrPoste.Value
                    || casting.Intitule != textBoxIntitule.Text
                    || casting.Description != textBoxDescPoste.Text
                    || casting.DescriptionProfilRecherche != textBoxDescProfil.Text
                    || casting.Email != textBoxEmail.Text
                    || casting.NumeroTelephone != textBoxPhone.Text
                    || casting.Fax != textBoxFax.Text
                    || casting.SiteWeb != textBoxWeb.Text
                    || casting.AdressePostale != textBoxAdrPostale.Text
                    || casting.Localisation != textBoxLocalisation.Text
                    || casting.IdentifiantMetier != comboBoxMetier.SelectedIndex
                    || casting.IdentifiantSexe != comboBoxSexe.SelectedIndex
                    || casting.IdentifiantTypeContrat - 1 != comboBoxTypeContrat.SelectedIndex)
                {
                    Console.WriteLine(comboBoxTypeContrat.SelectedIndex);
                    casting.Verifie = checkBoxVerif.Checked;
                    casting.Reference = labelReference.Text;
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
                    casting.IdentifiantMetier = comboBoxMetier.SelectedIndex;
                    casting.IdentifiantSexe = comboBoxSexe.SelectedIndex;
                    casting.IdentifiantTypeContrat = comboBoxTypeContrat.SelectedIndex + 1;

                    CastingDB.Update(casting);
                    InitListBoxCasting();
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult dialogResult = MessageBox.Show("Le casting " + casting.Intitule + " a bien été mis à jour !", "Succès", buttons, MessageBoxIcon.Information);
                }
            }

        }
        private void AddCasting(object sender, EventArgs e)
        {
            AddCasting addCasting = new AddCasting();
            addCasting.ShowDialog();
            if (addCasting.DialogResult == DialogResult.OK)
            {
                InitListBoxCasting();
            }
        }

        private void SearchCastings(object sender, EventArgs e)
        {
            if (textBoxSearch?.Text.Count() >= 3)
            {
                List<Casting> castings = CastingDB.Search(textBoxSearch.Text);
                listBoxCasting.Items.Clear();
                foreach (Casting casting in castings)
                {
                    listBoxCasting.Items.Add(casting);
                }
            }
            else
            {
                InitListBoxCasting();
            }
        }
    }

}

