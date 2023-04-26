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
            InitListBoxCasting();
            InitListBoxSexe();
        }

        private void ConfigSexes(object sender, EventArgs e)
        {

        }

        private void ConfigTypeContrat(object sender, EventArgs e)
        {

        }

        private void ConfigMetiers(object sender, EventArgs e)
        {

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

        private void InitListBoxSexe()
        {
            listBoxSexes.Items.Clear();

            if (listBoxCasting.SelectedItem != null)
            {
                Casting casting = (Casting)listBoxCasting.SelectedItem;
                List<Sexe> sexes = SexeDB.All();
                AllocConsole();
                Console.WriteLine(casting.IdentifiantSexes.ToList().Count);
                Console.WriteLine(casting.Identifiant);

                foreach (Sexe sexe in casting.IdentifiantSexes.ToList())
                {
                    Console.WriteLine("test2");
                    listBoxSexes.Items.Add(sexe);
                    foreach (Sexe s in sexes)
                    {
                        if (sexe.Identifiant == s.Identifiant)
                        {
                            listBoxSexes.Items.Add(s);
                        }
                    }
                }

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

                listBoxTypesContrat.Items.Clear();
                listBoxMetiers.Items.Clear();

                InitListBoxSexe();

                foreach (TypeContrat typeContrat in casting.IdentifiantTypeContrats)
                {
                    listBoxTypesContrat.Items.Add(typeContrat);
                }

                foreach (Metier metier in casting.IdentifiantMetiers)
                {
                    listBoxMetiers.Items.Add(metier);
                }

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
                    || casting.Localisation != textBoxLocalisation.Text)
                {
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



                    foreach (Sexe sexe in listBoxSexes.Items)
                    {
                        casting.IdentifiantSexes.Add(sexe);

                    }

                    foreach (TypeContrat typeContrat in listBoxTypesContrat.Items)
                    {
                        casting.IdentifiantTypeContrats.Add(typeContrat);
                    }

                    foreach (Metier metier in listBoxMetiers.Items)
                    {
                        casting.IdentifiantMetiers.Add(metier);
                    }

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

