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
            InitListBoxClient(listBoxClient);
        }
        private void InitListBoxClient(ListBox listbox)
        {
            listBoxClient.Items.Clear();
            List<Professionnel> professionnels = ProfessionnelDB.All();
            foreach (Professionnel abo in professionnels)
            {
                listbox.Items.Add(abo);
            }
            if (listbox.Items.Count > 0)
            {
                listbox.SelectedIndex = 0;
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
            InitListBoxClient(listBoxClient);
        }
    }
}
