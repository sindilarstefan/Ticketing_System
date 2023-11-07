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
using System.Collections.ObjectModel;

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
            AddItemsToListBox();
        }
        private void AddItemsToListBox()
        {
            // Create a collection to store items
            ObservableCollection<string> items = new ObservableCollection<string>();

            // Add items to the collection
            items.Add("Resurse Umane");
            items.Add("IT");
            items.Add("Logistica");

            // Set the ItemsSource property of the ListBox to the collection of items
            lista.ItemsSource = items;
        }
        private void subiect_changed(object sender, RoutedEventArgs e)
        {
            mesajnetrimis.Visibility = Visibility.Collapsed;
            mesajtrimis.Visibility = Visibility.Collapsed;
        }
        private void continut_changed(object sender, RoutedEventArgs e)
        {
            mesajnetrimis.Visibility = Visibility.Collapsed;
            mesajtrimis.Visibility = Visibility.Collapsed;
        }
        private void lista_changed(object sender, RoutedEventArgs e)
        {
            mesajnetrimis.Visibility = Visibility.Collapsed;
            mesajtrimis.Visibility = Visibility.Collapsed;
        }
        private void Trimite_Click(object sender, RoutedEventArgs e)
        {
            string _continut = Continut.Text;
            string _subiect = Subiect.Text;
            string _dep="";
            if(lista.SelectedItem==null)
            {
                mesajnetrimis.Visibility = Visibility.Visible;
            }
            else
            {
                 _dep = lista.SelectedItem.ToString();
            }

            if (_continut == "" || _subiect == ""||_dep=="")
                mesajnetrimis.Visibility = Visibility.Visible;
            else
            {

                mesajnetrimis.Visibility = Visibility.Collapsed;
                mesajtrimis.Visibility = Visibility.Visible;
            }

            //insert.insereazaTichet("teo@gmail.com", _continut, "IT");
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
