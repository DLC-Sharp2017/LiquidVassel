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
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace LiquidVassel
{
    /// <summary>
    /// Logique d'interaction pour     VueNavire3.xaml
    /// </summary>
    public partial class VueNavire3 : Page
    {
        public VueNavire3()
        {
            InitializeComponent();
            
            using (var vm = new VesselModel())
            {

                var query = (from b in vm.Bateaux

                             select b.Capitaine).ToList() ;
              
                laliste.Items.Add(query); 

                //for (int i = 0; i < query.Count; i++)
                //{
                //    laliste.Items.Add(query.ToList());
                //}

                //laliste.Items.Add(query.ToArray());
                //{
                //    listBox.Items.Add(query.ToList());
                //}


            }
        }
                

    
        private void modifié_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("vous allez modifié une nouvelle tourné");
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            DimentionNavire.Clear();
            Pays.Clear();
            NombreEquipage.Clear();
            TirEau.Clear();
            TotalSlots.Clear();
            NomNavire.Clear();
        }
        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("vous aller ajouter une tournée");
        }



       
    }

}