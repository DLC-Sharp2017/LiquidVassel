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

using Microsoft.Maps.MapControl.WPF;

namespace LiquidVassel
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class WindowTournee : Page
    {
        public WindowTournee()
        {
            InitializeComponent();

            carteTournee.Center = new Location(47.6421, -122.1420);

          
            Label label_port1 = new Label();
            label_port1.Content = "Test";

           spanelPort.Children.Add(label_port1);
           
          
                      

            using (var vm = new VesselModel())
            {
                var query = from b in vm.sequences
                            where b.IdRota=="MED"
                            orderby  b.dateDepart
                            select b.codePortDep;

                var portTournee = query.ToList();

                List<Label> listportTournee = new List<Label>();

                for (int i = 0; i < portTournee.Count; i++)
                {
                    string nomLabel = "label_port" + i.ToString();
                    listportTournee.Add(new Label { Name = nomLabel });
                 
                }
               
         

    }






}

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
