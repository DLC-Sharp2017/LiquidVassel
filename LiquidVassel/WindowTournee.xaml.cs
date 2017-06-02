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

            //Centre la carte sur des coordonnées
            carteTournee.Center = new Location(47.6421, -122.1420);               

            using (var vm = new VesselModel())
            {

                // Requête pour récuperer le nom complet et la catégorie du bateau depuis son identifiant (donné par page precédente ?) 
                var query3 = from b in vm.Bateaux
                             where b.IDmat == "HOLLVOL"
                             select b;

                textBlockNom.Text = query3.First().nameVsl;
                textBlockCat.Text = query3.First().cat;


                // Requête pour récuperer les rotations
                var query = (from b in vm.sequences
                            where b.IdRota=="MED"
                            orderby  b.dateDepart
                            select b.codePortDep).ToList();


                // Création des collections pour contenir les controls à créer dans l'interface
                var listLabelPort = new List<Label>();
                var listTextBlockPort = new List<TextBlock>();

                var listButtonDelete = new List<Button>();
                var listButtonModify = new List<Button>();
                var listButtonAdd = new List<Button>();



                // Récupération des styles définis dans la page.ressources du xaml
                Style labelStyle = this.FindResource("LabelStyle") as Style;
                Style buttonStyle = this.FindResource("ButtonStyle") as Style;  
                
                                                                    
                for (int i = 0; i < query.Count; i++)
                {
                   
                    //créer et ajouter à la liste les contrôles en leur donnant un nom et un numéro dynamiquement
                    listLabelPort.Add(new Label { Name = "label_port" + i.ToString() });
                    listTextBlockPort.Add(new TextBlock { Name = "textblock_port"+i.ToString()});
                    listButtonAdd.Add(new Button { Name = "ButtonAdd" + i.ToString() });
                    listButtonModify.Add(new Button { Name = "ButtonModify" + i.ToString() });
                    listButtonDelete.Add(new Button { Name = "ButtonDelete" + i.ToString() });
                    

                    //définition de la marge en code
                    Thickness m = listTextBlockPort[i].Margin;
                    m.Bottom = 25;
                    listTextBlockPort[i].Margin = m;

                    //affectation de la valeurs aux controles
                    listLabelPort[i].Content = query[i];
                    listTextBlockPort[i].Text = query[i];
                    listButtonAdd[i].Content = "+";
                    listButtonModify[i].Content = "~";
                    listButtonDelete[i].Content = "x";

                    //affectation du style
                    listLabelPort[i].Style = labelStyle;
                    listButtonAdd[i].Style = buttonStyle;
                    listButtonDelete[i].Style = buttonStyle;
                    listButtonModify[i].Style = buttonStyle;

                    //ajout des labels/txtblocks/buttons aux panels correspondants
                    spanelPort.Children.Add(listLabelPort[i]);
                    spanelPort2.Children.Add(listTextBlockPort[i]);
                    spanelAdd.Children.Add(listButtonAdd[i]);
                    spanelModify.Children.Add(listButtonModify[i]);
                    spanelDelete.Children.Add(listButtonDelete[i]);

                }

                //Requête pour récupérer les dates de départ et les associer aux labels des ports
                var query2 = (from b in vm.sequences
                         where b.IdRota == "MED"
                         orderby b.dateDepart
                         select b.dateDepart).ToList();

                List<TextBlock> listTextBlockDated = new List<TextBlock>();
                Style textblockStyle = this.FindResource("TextBlockStyle") as Style;

                for (int i = 0; i < query2.Count; i++)
                {
                    string nomTextBlock = "textblock_date" + i.ToString();
                    listTextBlockDated.Add(new TextBlock { Name = nomTextBlock });
                    //on récupère la date en affichant JJ/MM
                    listTextBlockDated[i].Text = new string (query2[i].ToString().Take(5).ToArray());
                    listTextBlockDated[i].Style = textblockStyle;
                   
                    spanelDate.Children.Add(listTextBlockDated[i]);
                }

            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
        /// <summary>
        /// Fonction liant les scrolls cachés des boutons au scroll visible de la liste des ports
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            ScrollDelete.ScrollToVerticalOffset(e.VerticalOffset);
            ScrollModify.ScrollToVerticalOffset(e.VerticalOffset);
            ScrollAdd.ScrollToVerticalOffset(e.VerticalOffset);

        }
    }
}
