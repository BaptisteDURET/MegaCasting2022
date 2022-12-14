using MegaCasting2022.DBLib.Requetes;
using MegaCasting2022.DBLib.tables;
using System.Windows.Forms;

namespace MegaCasting2022
{
    public partial class MegaCasting : Form
    {
        public MegaCasting()
        {
            InitializeComponent();
            InitForm();
        }

        private void AfficheViewClient(object sender, EventArgs e)
        {
            gestionCasting1.Hide();
            gestionPartenaire1.Hide();
            
            gestionClient1.Show();
            gestionClient1.BringToFront();
        }

        private void AfficheViewCasting(object sender, EventArgs e)
        {
            gestionPartenaire1.Hide();
            gestionClient1.Hide();
            
            gestionCasting1.Show();
            gestionCasting1.BringToFront();
        }

        private void AfficheViewPartenaire(object sender, EventArgs e)
        {
            gestionClient1.Hide();
            gestionCasting1.Hide();

            gestionPartenaire1.Show();
            gestionPartenaire1.BringToFront();
        }
        private void InitForm()
        {
            gestionCasting1.Hide();
            gestionPartenaire1.Hide();

            gestionClient1.Show();
            gestionClient1.BringToFront();
        }
    }
}