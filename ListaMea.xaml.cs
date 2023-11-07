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
    /// Interaction logic for ListaMea.xaml
    /// </summary>
    public partial class ListaMea : Page
    {
        public ListaMea()
        {
            InitializeComponent();
            PopulateDataGrid();
        }
        private void ListaMea_Click(object sender, RoutedEventArgs e)
        {

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
        private void PopulateDataGrid()
        {
            // Sample data for the DataGrid
            List<YourDataType> dataList = new List<YourDataType>
            {
                new YourDataType { Nr = "Value1", Departament = "Valgreaaaaaaaa\n aarrrrrrrrrrrrrr\n rrrrrrrrrrrrrrrrrrrrrr\n rrrrrue2" },
                new YourDataType { Nr = "Value3", Departament = "Value4" },
                new YourDataType { Nr = "Value3", Departament = "Value4" },
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
            // Add more properties as needed
        }
    }
}
