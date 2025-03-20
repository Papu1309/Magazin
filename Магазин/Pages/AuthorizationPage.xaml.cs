using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using Магазин.Magas;

namespace Магазин.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void btnVxod_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Vid());
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
           
            NavigationService.Navigate(new RegistrationPage());
        }
    }
}
