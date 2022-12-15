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
    public partial class AddPartenaire : Form
    {
        public AddPartenaire()
        {
            InitializeComponent();
        }

        private void ValiderAjoutPartenaire(object sender, EventArgs e)
        {
            bool valid = true;
            if (textBoxUsername.Text == "" || textBoxPassword.Text == "" || textBoxEntreprise.Text == "" || textBoxEmail.Text == "" || textBoxPhone.Text == "")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult dialogResult = MessageBox.Show("Aucun champ ne doit être vide !", "Erreur", buttons, MessageBoxIcon.Error);
                valid = false;
            }

            if (textBoxUsername.Text.Length > 50 || textBoxUsername.Text.Length < 3)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult dialogResult = MessageBox.Show("Le nom d'utilisateur doit faire entre 3 et 50 charactères !", "Erreur", buttons, MessageBoxIcon.Error);
                valid = false;
            }

            if (textBoxPassword.Text.Length > 80 || textBoxPassword.Text.Length < 8)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult dialogResult = MessageBox.Show("Le mot de passe doit faire entre 8 et 80 charactères !", "Erreur", buttons, MessageBoxIcon.Error);
                valid = false;
            }

            if (textBoxPhone.Text.Length < 10)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult dialogResult = MessageBox.Show("Le numéro de téléphone doit faire au moins 10 charactères !", "Erreur", buttons, MessageBoxIcon.Error);
                valid = false;
            }

            if (textBoxEmail.Text.Length > 150)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult dialogResult = MessageBox.Show("L'adresse mail doit faire au maximum 150 charactères !", "Erreur", buttons, MessageBoxIcon.Error);
                valid = false;
            }

            if (textBoxEntreprise.Text.Length > 50)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult dialogResult = MessageBox.Show("Le nom de l'entreprise doit faire au maximum 50 charactères !", "Erreur", buttons, MessageBoxIcon.Error);
                valid = false;
            }

            Professionnel p = ProfessionnelDB.CheckUniqueUsername(textBoxUsername.Text);
            if (p != null)
            {
                valid = false;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult dialogResult = MessageBox.Show("Ce nom d'utilisateur est déjà utilisé !", "Erreur", buttons, MessageBoxIcon.Error);
            }

            if (valid == true)
            {
                PartenaireDiffusion par = new PartenaireDiffusion();
                par.NomUtilisateur = textBoxUsername.Text;
                par.Email = textBoxEmail.Text;
                par.NumeroTelephone = textBoxPhone.Text;
                par.MotDePasse = textBoxPassword.Text;
                par.Entreprise = textBoxEntreprise.Text;
                if (checkBoxVerif.Checked == true)
                {
                    par.Verifie = true;
                }
                else
                {
                    par.Verifie = false;
                }
                PartenaireDB.Insert(par);
                this.Close();
                this.DialogResult = DialogResult.OK;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult dialogResult = MessageBox.Show("Le client " + par.NomUtilisateur + " de l'entreprise " + par.Entreprise + " a bien été ajouté !", "Succès", buttons, MessageBoxIcon.Information);
            }
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
