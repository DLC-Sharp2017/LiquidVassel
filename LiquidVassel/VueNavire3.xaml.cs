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
    /// Logique d'interaction pour VueNavire3.xaml
    /// </summary>
    public partial class VueNavire3 : Window
    {
        public VueNavire3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            text1.Clear();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            text2.Clear();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            text3.Clear();
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            textB2.Clear();
        }

        private void button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            textB1.Clear();
        }

        private void modifié_Click(object sender, RoutedEventArgs e)
        {

        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            text1.Clear();
            text2.Clear();
            text3.Clear();
            textB2.Clear();
            textB1.Clear();
            textnom.Clear();


        }
        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


    }



}