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

namespace ATM_Tiketing
{
    /// <summary>
    /// Interaction logic for TipCont.xaml
    /// </summary>
    public partial class TipCont : Page
    {
        public TipCont()
        {
            InitializeComponent();
        }

        private void Obisnuit_Click(object sender, RoutedEventArgs e)
        {
           
            mainFrame.Content = null;
            SignUP signupPage = new SignUP();
            mainFrame.NavigationService.Navigate(signupPage);
        }
        private void Angajat_Click(object sender, RoutedEventArgs e)
        {
            introdu.Visibility=Visibility.Visible;
            border.Visibility = Visibility.Visible;
            cod.Visibility=Visibility.Visible;
            inainte.Visibility = Visibility.Visible;
            gresit.Visibility = Visibility.Collapsed;

        }
        private void Inainte_Click(object sender, RoutedEventArgs e)
        {
            string codul = cod.Password;
            if (codul == "1004")
            {
                mainFrame.Content = null;
                SignUP signupPage = new SignUP();
                mainFrame.NavigationService.Navigate(signupPage);
            }
            else
            {
                gresit.Visibility = Visibility.Visible;
            }
        }
        private void Inapoi_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = null;
            this.Content = null;
            PagPrincipala pag = new PagPrincipala();
            mainFrame.NavigationService.Navigate(pag);
        }

        private void cod_PasswordChanged(object sender, RoutedEventArgs e)
        {
            gresit.Visibility = Visibility.Collapsed;
        }
    }
}
