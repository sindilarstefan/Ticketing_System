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
    /// Interaction logic for TicheteRezolvateClient.xaml
    /// </summary>
    public partial class TicheteRezolvateClient : Page
    {
        public TicheteRezolvateClient()
        {
            InitializeComponent();
            PopulateDataGrid();
        }
        private void ListaMea_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = null;
            ListaMea Page = new ListaMea();
            mainFrame.NavigationService.Navigate(Page);
        }
        private void SchiteButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = null;
        }
        private void TiketsButton_Click2(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = null;
            CompuneTichet Page = new CompuneTichet();
            mainFrame.NavigationService.Navigate(Page);
        }
        private void Rezolvate_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = null;
            TicheteRezolvateClient pag = new TicheteRezolvateClient();
            mainFrame.NavigationService.Navigate(pag);

        }
        private void Nerezolvate_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = null;
            TicheteNerezolvateClient pag = new TicheteNerezolvateClient();
            mainFrame.NavigationService.Navigate(pag);
        }
        private void PopulateDataGrid()
        {
            List<YourDataType> dataList = new List<YourDataType>
            {
                new YourDataType { Nr = "Value1", Departament = "" }
            };

            dataGrid.Foreground = Brushes.Blue;
            dataGrid.RowBackground = Brushes.RosyBrown;
            dataGrid.AlternatingRowBackground = Brushes.LightSkyBlue;
            dataGrid.ItemsSource = dataList;
        }

        public class YourDataType
        {
            public string Nr { get; set; }
            public string Departament { get; set; }
            public string Subiect { get; set; }
            public string Continut { get; set; }
            public string Solutie { get; set; }
            public string Prioritate { get; set; }
        }
    }
}
