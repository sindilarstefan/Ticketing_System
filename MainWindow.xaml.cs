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
using System.Threading;
using System.Windows.Shapes;

namespace ATM_Tiketing
{
    public partial class MainWindow : Window
    {
        
        BazaDate bd = BazaDate.GetInstance();
        IntroduInBD insert = new IntroduInBD();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void ContNouButton_Click(object sender, RoutedEventArgs e)
        {
            
            mainFrame.Content = null;
            SignUP signupPage = new SignUP();
            signupPage.BackNavigationService = mainFrame.NavigationService;
            mainFrame.NavigationService.Navigate(signupPage);
            CreareContNou.Visibility = Visibility.Collapsed;
        }
        private void Autentificare_Click(object sender, RoutedEventArgs e)
        {
           
            string _email = email.Text;
            string _parola = parola.Password;

            if (insert.verificaUtilizator(_email, _parola) == false)
                MessageBox.Show("Cont inexistent !", "ATM Platform", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                MessageBox.Show("Autentificare cu succes!", "ATM Platform", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                try
                {
                    Window2 wn = new Window2();
                    wn.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening new window: {ex.Message}");
                }
            } 
        }
    }
}
