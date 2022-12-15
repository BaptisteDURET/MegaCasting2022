using MegaCasting2022.DBLib.Requetes;
using MegaCasting2022.DBLib.tables;
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
    public partial class GestionPartenaire : UserControl
    {
        public GestionPartenaire()
        {
            InitializeComponent();
            initListBoxPartenaire();
        }

        private void initListBoxPartenaire()
        {
            listBoxPartenaire.Items.Clear();
            List<PartenaireDiffusion> partenaires = PartenaireDB.All();
            foreach (PartenaireDiffusion part in partenaires)
            {
                listBoxPartenaire.Items.Add(part);
            }
            if (listBoxPartenaire.Items.Count > 0)
            {
                listBoxPartenaire.SelectedIndex = 0;
            }
        }
        private void UpdatePartenaireInfo(object sender, EventArgs e)
        {
            if(listBoxPartenaire.SelectedItem != null)
            {
                PartenaireDiffusion partenaire = (PartenaireDiffusion)listBoxPartenaire.SelectedItem;
                labelId.Text = partenaire.Identifiant.ToString();
                textBoxUsername.Text = partenaire.NomUtilisateur;
                textBoxPhone.Text = partenaire.NumeroTelephone;
                textBoxEmail.Text = partenaire.Email;
                textBoxEntreprise.Text = partenaire.Entreprise;
                if (partenaire.Verifie)
                {
                    checkBoxVerif.Checked = true;
                }
                else
                {
                    checkBoxVerif.Checked = false;
                }
            }
        }

        private void DeletePartenaire(object sender, EventArgs e)
        {
            PartenaireDiffusion partenaire = (PartenaireDiffusion)listBoxPartenaire.SelectedItem;
            PartenaireDB.Delete(partenaire);
            initListBoxPartenaire();
        }

        private void UpdatePartenaire(object sender, EventArgs e)
        {
            PartenaireDiffusion par = (PartenaireDiffusion)listBoxPartenaire.SelectedItem;
            if (textBoxUsername.Text != par.NomUtilisateur || textBoxPhone.Text != par.NumeroTelephone || textBoxEmail.Text != par.Email || textBoxEntreprise.Text != par.Entreprise || checkBoxVerif.Checked != par.Verifie)
            {
                Professionnel p = new Professionnel();
                par.NomUtilisateur = textBoxUsername.Text;
                par.NumeroTelephone = textBoxPhone.Text;
                par.Email = textBoxEmail.Text;
                par.Entreprise = textBoxEntreprise.Text;
                par.Verifie = checkBoxVerif.Checked;
                PartenaireDB.Update(par);
                initListBoxPartenaire();
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult dialogResult = MessageBox.Show("Le partenaire " + par.NomUtilisateur + " de l'entreprise " + par.Entreprise + " a bien été mis à jour !", "Succès", buttons, MessageBoxIcon.Information);
            }
        }

        private void AddPartenaire(object sender, EventArgs e)
        {
            AddPartenaire addPartenaire = new AddPartenaire();
            addPartenaire.ShowDialog();
            if (addPartenaire.DialogResult == DialogResult.OK)
            {
                initListBoxPartenaire();
            }
        }
    }
}
