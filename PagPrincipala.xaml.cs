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
    public partial class PagPrincipala : Page
    {
        IntroduInBD insert = new IntroduInBD();
        public PagPrincipala()
        {
            InitializeComponent();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            mesajaut.Visibility = Visibility.Collapsed;
        }
        private void ContNouButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = null;
            TipCont page = new TipCont();
            mainFrame.NavigationService.Navigate(page);
        }
        private void Autentificare_Click(object sender, RoutedEventArgs e)
        {

            string _email = email.Text;
            string _parola = parola.Password;

            if (insert.verificaUtilizator(_email, _parola) == true)
                mesajaut.Visibility = Visibility.Visible;
            else
            {
                try
                {
                    bool isTargetWindowOpen = Application.Current.Windows.OfType<Window2>().Any();
                    if (!isTargetWindowOpen)
                    {
                        Window2 wn = new Window2();
                        wn.Show();
                        Window parentWindow = Window.GetWindow(this);
                        parentWindow?.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error opening new window: {ex.Message}");
                }
            }
        }

        private void parola_PasswordChanged(object sender, RoutedEventArgs e)
        {
            mesajaut.Visibility = Visibility.Collapsed;
        }
    }
}
