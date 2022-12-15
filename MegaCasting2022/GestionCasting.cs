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

        private void ConfigMétiers(object sender, EventArgs e)
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
                labelId.Text = casting.Identifiant.ToString();
                labelReference.Text = casting.Reference;
                textBoxIntitule.Text = casting.Intitule;
                dateTimePickerDebutPubli.Value = casting.DateDebutPublication;
                dateTimePickerDebutContrat.Value = casting.DateDebutContrat;
                textBoxDescPoste.Text = casting.Description;
                
            }
        }
    }
}
