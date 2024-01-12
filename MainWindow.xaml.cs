using mega_grid_warhammer.View;
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

namespace mega_grid_warhammer
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); 
        }

        private void CB_persos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ///fuauf
        }

        private void BT_army_rules_Click(object sender, RoutedEventArgs e)
        {
            affichage.Children.Clear();
            army_rule army_Rule = new army_rule();
            affichage.Children.Add(army_Rule);
        }
    }
}
