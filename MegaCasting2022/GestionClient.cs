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
    public partial class GestionClient : UserControl
    {
        public GestionClient()
        {
            InitializeComponent();
            InitListBoxClient();
        }
        private void InitListBoxClient()
        {
            listBoxClient.Items.Clear();
            List<Professionnel> professionnels = ProfessionnelDB.All();
            foreach (Professionnel abo in professionnels)
            {
                listBoxClient.Items.Add(abo);
            }
            if (listBoxClient.Items.Count > 0)
            {
                listBoxClient.SelectedIndex = 0;
            }
        }

        private void UpdateClientInfo(object sender, EventArgs e)
        {
            if(listBoxClient.SelectedItem != null)
            {
                Professionnel professionnel = (Professionnel)listBoxClient.SelectedItem;
                labelId.Text = professionnel.Identifiant.ToString();
                textBoxUsername.Text = professionnel.NomUtilisateur;
                textBoxEntreprise.Text = professionnel.Entreprise;
                textBoxEmail.Text = professionnel.Email;
                textBoxPhone.Text = professionnel.NumeroTelephone;
                if (professionnel.Verifie == true)
                {
                    checkBoxVerif.Checked = true;
                }
                else
                {
                    checkBoxVerif.Checked = false;
                }
            }
        }

        private void DeleteClient(object sender, EventArgs e)
        {
            Professionnel pro = (Professionnel)listBoxClient.SelectedItem;
            ProfessionnelDB.Delete(pro);
            InitListBoxClient();
        }

        private void AddClient(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
            addClient.ShowDialog();
            if (addClient.DialogResult == DialogResult.OK)
            {
                InitListBoxClient();
            }
        }

        private void ModifyClient(object sender, EventArgs e)
        {
            Professionnel pro = (Professionnel)listBoxClient.SelectedItem;
            if (textBoxUsername.Text != pro.NomUtilisateur || textBoxPhone.Text != pro.NumeroTelephone || textBoxEmail.Text != pro.Email || textBoxEntreprise.Text != pro.Entreprise || checkBoxVerif.Checked != pro.Verifie)
            {
                Professionnel p = new Professionnel();
                pro.NomUtilisateur = textBoxUsername.Text;
                pro.NumeroTelephone = textBoxPhone.Text;
                pro.Email = textBoxEmail.Text;
                pro.Entreprise = textBoxEntreprise.Text;
                pro.Verifie = checkBoxVerif.Checked;
                ProfessionnelDB.Update(pro);
                InitListBoxClient();
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult dialogResult = MessageBox.Show("Le client " + pro.NomUtilisateur + " de l'entreprise " + pro.Entreprise + " a bien été mis à jour !", "Succès", buttons, MessageBoxIcon.Information);
            }
        }
    }
}
