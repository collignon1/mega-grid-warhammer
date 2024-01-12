using mega_grid_warhammer.View.View2;
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

namespace mega_grid_warhammer.View
{
    /// <summary>
    /// Logique d'interaction pour army_rule.xaml
    /// </summary>
    public partial class army_rule : UserControl
    {
        public army_rule()
        {
            InitializeComponent();
        }

        private void BTN_cabal_Click(object sender, RoutedEventArgs e)
        {
            affichage2.Children.Clear();
            cabale Cabale = new cabale();
            affichage.Children.Add(Cabale);
        }

        private void BTN_detachement_rule_Click(object sender, RoutedEventArgs e)
        {
            affichage2.Children.Clear();
            REGLES regles = new REGLES();
            affichage.Children.Add(regles);
        }

        private void BTN_detachement_enhancement_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
