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
    /// Logique d'interaction pour VueDashboard.xaml
    /// </summary>
    public partial class VueDashboard : Page
    {
        public VueDashboard()
        {
            InitializeComponent();
            myMap.Center = new Microsoft.Maps.MapControl.WPF.Location(57.262158, 6.741457);

            using (var navire = new VesselModel())
            {
                var navirArma = (from arnav in navire.Armateurs
                                 join navar in navire.Bateaux
                                 on arnav.Idarma equals navar.IDmat
                                 select arnav).ToList();

                for (int i = 0; i < navirArma.Count; i++)
                {
                    navirArma.
                }
                
                
            }
        }

        private void StackPanel_MouseUpBatBat(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Bateau");
        }
        private void StackPanel_MouseUpAno(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Anomalie");
        }

        private void ClickTournee(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tournée");
        }



        //private void StackPanel_MouseUp(object sender, MouseButtonEventArgs e)
        //{
        //    if (sender == Bateau)
        //    {
        //        MessageBox.Show("Bateau");
        //    }
        //    if (sender == Anomalie)
        //    {
        //        MessageBox.Show("Anomalie");
        //    }
        //}
    }
}
