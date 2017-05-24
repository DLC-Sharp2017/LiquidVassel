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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LiquidVassel
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
	/// <summary>
	/// Main
	///</summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSign_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Connecté");
            //using (var connect = new LoginModel())
            //{

            //}
        }

        /// <summary>
        /// Méthode close() appli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult msgSortie = MessageBox.Show("Are you sure ?", "Exit", MessageBoxButton.YesNoCancel);
            if (msgSortie == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }


    }


}
