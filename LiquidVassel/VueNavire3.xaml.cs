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

            try
            {

                using (var vm = new VesselModel())
                {
                    var query = (from b in vm.Rotations
                                 select b.nom).ToList();
                    // recuperer une collection de donné 
                    foreach (var item in query)
                    {
                        //convertir chaque element de la collection en string 
                        var affiche = item.ToString();
                        // afficher les string dans un combobox
                        comboBox.Items.Add(affiche);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        private void modifié_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("vous allez modifié une nouvelle tourné");
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {

            Idmatricule.Clear();
            Tireaux.Clear();
            LongeurBateaux.Clear();
            NombreEquipages.Clear();
            textnom.Clear();
            IDdeCapitaine.Clear();
            Categorie.Clear();
            idqPays.Clear();
            idarmateur.Clear();
            idrotation.Clear();
            LargeurBateu.Clear();
            

        }
        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("vous aller ajouter une tournée");
        }

        private void Pavillon_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ajoutertourner_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("vous aller ajouter une tourné");
            AjouteruneTourner aj = new AjouteruneTourner();
            aj.Show();



        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                using (var vm = new VesselModel())
                {
                    Bateau bat = new Bateau();
                    bat.IDmat = Idmatricule.Text;
                    bat.nameVsl = textnom.Text;
                    bat.IDcapitaine = IDdeCapitaine.Text;
                    bat.cat = Categorie.Text;
                    bat.IdPays = idqPays.Text;
                    bat.Idarma = idarmateur.Text;
                    bat.longVsl = int.Parse(LongeurBateaux.Text);
                    bat.tirEau = int.Parse(Tireaux.Text);
                    bat.largVsl = int.Parse(LargeurBateu.Text);
                    bat.nbreEquipage = int.Parse(NombreEquipages.Text);
                    bat.IDcapitaine = IDdeCapitaine.Text;
                    bat.IdRota = idrotation.Text;
                    vm.Bateaux.Add(bat);
                    vm.SaveChanges();
                    MessageBox.Show("BATEAU ajouter avec succé");
                }
            }
            catch (OverflowException j)
            {
                MessageBox.Show(j.Message);
            }
            catch (ArgumentNullException k)
            {
                MessageBox.Show(k.Message);
            }

            catch (FormatException l)
            {
                MessageBox.Show(l.Message);
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }

        }


        private void LargeurBateu_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }



}
