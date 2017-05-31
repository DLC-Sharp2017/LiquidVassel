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

            using (var vm = new VesselModel())
            {
                var query = (from b in vm.sequences
                            where b.IdRota=="MED"
                            orderby  b.dateDepart
                            select b.codePortDep).ToList();

   

                List<Label> listportTournee = new List<Label>();
                Style labelStyle = this.FindResource("LabelStyle") as Style;

                for (int i = 0; i < query.Count; i++)
                {
                    string nomLabel = "label_port" + i.ToString();
                    listportTournee.Add(new Label { Name = nomLabel });
                    listportTournee[i].Content = query[i];
                    listportTournee[i].Style = labelStyle;
                    
                    spanelPort.Children.Add(listportTournee[i]);
                }


                var query2 = (from b in vm.sequences
                         where b.IdRota == "MED"
                         orderby b.dateDepart
                         select b.dateDepart).ToList();

                List<TextBlock> listdateTournee = new List<TextBlock>();
                Style textblockStyle = this.FindResource("TextBlockStyle") as Style;

                for (int i = 0; i < query2.Count; i++)
                {
                    string nomTextBlock = "textblock_date" + i.ToString();
                    listdateTournee.Add(new TextBlock { Name = nomTextBlock });
                    listdateTournee[i].Text = new string (query2[i].ToString().Take(5).ToArray());
                    listdateTournee[i].Style = textblockStyle;
                   
                    spanelDate.Children.Add(listdateTournee[i]);
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
