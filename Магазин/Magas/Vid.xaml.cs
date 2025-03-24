using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
    /// Логика взаимодействия для Vid.xaml
    /// </summary>
    public partial class Vid : Page
    {
        public BindingList<Spicok> Spicokk; 
        public Vid()
        {
            InitializeComponent();
        }
        

        private void btnKorzina_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Spicokk = new BindingList<Spicok>()
            {
                new Spicok() {Name = "saa",Price = 123,Choise = true,Foto = "/Photo/AMORT.jpg" },
                new Spicok() {Name = "dssa"},
            };

            spicokGrid.ItemsSource = Spicokk;
        }
    }
}
