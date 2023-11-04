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
    /// Interaction logic for CompuneTichet.xaml
    /// </summary>
    public partial class CompuneTichet : Page
    {
        IntroduInBD insert = new IntroduInBD();
        public CompuneTichet()
        {
            InitializeComponent();
        }
        private void Trimite_Click(object sender, RoutedEventArgs e)
        {
            string _continut = Continut.Text;
            string _subiect = Subiect.Text;

            insert.insereazaTichet("teo@gmail.com", _continut, "IT");
        }
        private void ListaMea_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = null;
            ListaMea Page = new ListaMea();
            mainFrame.NavigationService.Navigate(Page);
        }
        private void TiketsButton_Click2(object sender, RoutedEventArgs e)
        {

        }
        private void ListBox_SelectionChanged3(object sender, NavigationEventArgs e)
        {

        }
        private void TextBox_TextChanged(object sender, NavigationEventArgs e)
        {

        }
        private void TextBox_TextChanged3(object sender, NavigationEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
   
}
