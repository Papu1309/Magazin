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
using Магазин.Datagrid;

namespace Магазин.Magas
{
    /// <summary>
    /// Логика взаимодействия для Corzina.xaml
    /// </summary>
    public partial class Corzina : Window
    {
        public Corzina(List<Spicok> selectedSpicoks)
        {
            InitializeComponent();
            SelectedSpicoksListView.ItemsSource = selectedSpicoks;

        }

        private void btnCarculate_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new aa());
        }
    }
}
