using MegaCasting2022.DBLib.Requetes;
using MegaCasting2022.DBLib.tables;
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

namespace MegaCasting2022
{
    public partial class GestionCasting : UserControl
    {
        public GestionCasting()
        {
            InitializeComponent();
            initListBoxCasting();
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

        private void initListBoxCasting()
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
            if(listBoxCasting.SelectedItems != null)
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

                listBoxSexes.Items.Clear();
                listBoxTypesContrat.Items.Clear();
                listBoxMetiers.Items.Clear();

                //Sexe s = new Sexe();
                //listBoxSexes.Items.Add(s);
                //listBoxSexes.Items.Add(s);
                //listBoxSexes.Items.Add(s);
                //listBoxSexes.Items.Add(s);
                //listBoxSexes.Items.Add(s);
                //listBoxSexes.Items.Add(s);
                
                foreach (Sexe sexe in casting.IdentifiantSexes)
                {
                    listBoxSexes.Items.Add(sexe);
                }

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
                initListBoxCasting();
            }
        }

        private void UpdateCasting(object sender, EventArgs e)
        {
            if (listBoxCasting.SelectedItems != null)
            {
                Casting casting = (Casting)listBoxCasting.SelectedItem;
                if (casting.Verifie != checkBoxVerif.Checked || casting.Reference != labelReference.Text || casting.DateDebutPublication != dateTimePickerDebutPubli.Value || casting.DateDebutContrat != dateTimePickerDebutContrat.Value || casting.DureeDiffusion != numericUpDownDureeDiff.Value || casting.NombrePosteDispo != numericUpDownNbrPoste.Value || casting.Intitule != textBoxIntitule.Text || casting.Description != textBoxDescPoste.Text || casting.DescriptionProfilRecherche != textBoxDescProfil.Text || casting.Email != textBoxEmail.Text || casting.NumeroTelephone != textBoxPhone.Text || casting.Fax != textBoxFax.Text || casting.SiteWeb != textBoxWeb.Text || casting.AdressePostale != textBoxAdrPostale.Text || casting.Localisation != textBoxLocalisation.Text)
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
                    initListBoxCasting();
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
                initListBoxCasting();
            }
        }
    }

}

