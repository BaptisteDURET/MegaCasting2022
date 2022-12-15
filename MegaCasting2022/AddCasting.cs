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
    public partial class AddCasting : Form
    {
        public AddCasting()
        {
            InitializeComponent();
            comboBoxClient.Items.Clear();
            comboBoxClient.DataSource = ProfessionnelDB.All();
            if (comboBoxClient.Items.Count > 0)
            {
                comboBoxClient.SelectedIndex = 0;
            }
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertCasting(object sender, EventArgs e)
        {
            Casting casting = new Casting();
            casting.Reference = RandomString(60);
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
