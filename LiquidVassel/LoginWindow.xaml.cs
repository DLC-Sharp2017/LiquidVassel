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
    public partial class LoginWindow : Page
    {
	/// <summary>
	/// Verification Connection 
	///</summary>
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnSign_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var connect = new VesselModel())
                {
                    string login = txtId.Text;
                    string passWord = pswPassword.Password;


                    var loginQuery = (from ar in connect.Armateurs
                                      where login == ar.LoginArma
                                      where passWord == ar.Motdepassearma
                                      select ar).ToList();

                    if (loginQuery.Count == 1)
                    {
                        MessageBox.Show("Vous êtes connecté!");
                        Page VueDashboard = new Page();
                        this.NavigationService.Navigate(VueDashboard);
                    }
                    else
                    {
                        MessageBox.Show("You shall not pass !");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Votre délai d'attente est dépassé \n" + ex.Message);
            }
            
        }

        /// <summary>
        /// Bouton Exit
        /// Méthode close() appli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult msgSortie = MessageBox.Show("Are you sure ?", "Exit", MessageBoxButton.YesNoCancel);
            if (msgSortie == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
        }



       
            }

        
        }


   