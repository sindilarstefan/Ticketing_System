﻿using System;
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
    /// Interaction logic for TicheteleMele.xaml
    /// </summary>
    public partial class TicheteleMele : Page
    {
        public TicheteleMele()
        {
            InitializeComponent();
        }
        private void TiketsButton_Click2(object sender, RoutedEventArgs e)
        {
           
        }
        private void CompuneButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = null;
            CompuneTichet Page = new CompuneTichet();
            mainFrame.NavigationService.Navigate(Page);
        }
        private void ListaMea_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = null;
            ListaMea Page = new ListaMea();
            mainFrame.NavigationService.Navigate(Page);
        }


    }
}
