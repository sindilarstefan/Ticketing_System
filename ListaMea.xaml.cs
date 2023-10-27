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

        }
    }
}
