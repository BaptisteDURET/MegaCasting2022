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
using BCrypt.Net;

namespace MegaCasting2022
{
    public partial class AddPartenaire : Form
    {
        public AddPartenaire()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void ValiderAjoutPartenaire(object sender, EventArgs e)
        {
            bool valid = true;
            string errors = "";
            if (textBoxUsername.Text == "" || textBoxPassword.Text == "" || textBoxEntreprise.Text == "" || textBoxEmail.Text == "" || textBoxPhone.Text == "")
            {
                errors += "Aucun champ ne doit être vide !\n";
                valid = false;
            }

            if (textBoxUsername.Text.Length > 50 || textBoxUsername.Text.Length < 3)
            {
                errors += "Le nom d'utilisateur doit faire entre 3 et 50 charactères !\n";
                valid = false;
            }

            if (textBoxPassword.Text.Length > 80 || textBoxPassword.Text.Length < 8)
            {
                errors += "Le mot de passe doit faire entre 8 et 80 charactères !\n";
                valid = false;
            }

            if (textBoxPhone.Text.Length < 10)
            {
                errors += "Le numéro de téléphone doit faire au moins 10 charactères !\n";
                valid = false;
            }

            if (textBoxEmail.Text.Length > 150)
            {
                errors += "L'adresse mail doit faire au maximum 150 charactères !\n";
                valid = false;
            }

            if (textBoxEntreprise.Text.Length > 50)
            {
                errors += "Le nom de l'entreprise doit faire au maximum 50 charactères !\n";
                valid = false;
            }

            Professionnel p = ProfessionnelDB.CheckUniqueUsername(textBoxUsername.Text);
            if (p != null)
            {
                errors += "Ce nom d'utilisateur est déjà utilisé !\n";
                valid = false;
            }

            if (valid == true)
            {
                PartenaireDiffusion par = new PartenaireDiffusion();
                par.Nom = textBoxUsername.Text;
                par.Email = textBoxEmail.Text;
                par.NumeroTelephone = textBoxPhone.Text;
                par.MotDePasse = BCrypt.Net.BCrypt.HashPassword(textBoxPassword.Text);
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
                DialogResult dialogResult = MessageBox.Show("Le client " + par.Nom + " de l'entreprise " + par.Entreprise + " a bien été ajouté !", "Succès", buttons, MessageBoxIcon.Information);
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult dialogResult = MessageBox.Show(errors, "Erreur", buttons, MessageBoxIcon.Error);
            }
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
