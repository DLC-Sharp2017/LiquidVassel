using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LiquidVassel
{
    /// <summary>
    /// Logique d'interaction pour AjouteruneTourner.xaml
    /// </summary>
    public partial class AjouteruneTourner : Window
    {

        public AjouteruneTourner()
        {
            InitializeComponent();

        }

        private void enregistrer_Click(object sender, RoutedEventArgs e)
        {

            // message d'erreur specifique si les deux champs sont vide 
            if ((nomTourner.Text == "") && (idtourner.Text == ""))
            {
                MessageBox.Show("aucun champs n'est rempli ");
            }
            // message specifique si le chmps tourné est vide 
            else if (nomTourner.Text == "")
            {
                MessageBox.Show("champs nom tourné est vide veuillez le mentionné svp ");
            }
            // MessageBox specifique si le champs id est vide 
            else if (idtourner.Text == "")
            {
                MessageBox.Show("champs IdTourné est vide veuillez le mentionné svp ");
            }

            // methode permet d'ajouter une nouvelle rotation 
            using (var vm = new VesselModel())
            {
                try
                {
                    Rotation rot = new Rotation();
                    rot.nom = nomTourner.Text;
                    rot.IdRota = idtourner.Text;
                    vm.Rotations.Add(rot);
                    vm.SaveChanges();
                    MessageBox.Show("element ajouter avec succé");
                }
                catch (Exception k)
                {

                    MessageBox.Show(k.Message);
                }

            }

        }
    }
}