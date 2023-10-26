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
    public partial class SignUP : Page
    {
        IntroduInBD insert = new IntroduInBD();
        public NavigationService BackNavigationService { get; set; }
        public SignUP()
        {
            InitializeComponent();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button Clicked!");
           
        }
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            string _nume = nume.Text;
            string _prenume = prenume.Text;
            string _email = email.Text;
            string _telefon = telefon.Text;
            string _parola = parola.Password;
            string _confirmare = confirmareparola.Password;

            if(_parola!=_confirmare)
            {
                MessageBox.Show("Parolele nu coincid !", "ATM Tiketing System", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
               
                if (insert.verificaUtilizator(_email, _parola) == true)
                    MessageBox.Show("Cont deja existent !", "ATM Platform", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                else
                {
                    insert.insereazaUtilizator(_nume, _prenume, _email, _telefon, _parola);
                    MessageBox.Show("Cont creat cu succes!", "ATM Platform", MessageBoxButton.OK, MessageBoxImage.Information);
                    mainFrame.Content = null;
                    PagPrincipala pag = new PagPrincipala();
                    mainFrame.NavigationService.Navigate(pag);
                }
               
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void mainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void mainFrame_Navigated_1(object sender, NavigationEventArgs e)
        {

        }
        private void Departament_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }
        
    }
}
