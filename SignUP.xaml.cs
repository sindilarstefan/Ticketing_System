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
using System.Threading;

namespace ATM_Tiketing
{
    public partial class SignUP : Page
    {
        IntroduInBD insert = new IntroduInBD();
        private MainWindow _mainWindow;
        public NavigationService BackNavigationService { get; set; }
        public SignUP()
        {
            InitializeComponent();
        }
 
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            existent.Visibility = Visibility.Collapsed;
            nucoinide.Visibility = Visibility.Collapsed;
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
                existent.Visibility = Visibility.Collapsed;
                nucoinide.Visibility = Visibility.Visible;

            }
            else
            {

                if (insert.verificaDisponibilitateCont(_email) == true)
                {
                    existent.Visibility = Visibility.Visible;
                    nucoinide.Visibility = Visibility.Collapsed;
                }
                   
                else
                {
                    succes.Visibility = Visibility.Visible;
                    Thread.Sleep(1000);
                    insert.insereazaUtilizator(_nume, _prenume, _email, _telefon, _parola);
                    mainFrame.Content = null;
                    PagPrincipala pag = new PagPrincipala();
                  
                    mainFrame.NavigationService.Navigate(pag);
                }
               
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            existent.Visibility = Visibility.Collapsed;
            nucoinide.Visibility = Visibility.Collapsed;
        }

        private void mainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            existent.Visibility = Visibility.Collapsed;
            nucoinide.Visibility = Visibility.Collapsed;
        }

        private void mainFrame_Navigated_1(object sender, NavigationEventArgs e)
        {
            existent.Visibility = Visibility.Collapsed;
            nucoinide.Visibility = Visibility.Collapsed;
        }
        private void Departament_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            existent.Visibility = Visibility.Collapsed;
            nucoinide.Visibility = Visibility.Collapsed;
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            existent.Visibility = Visibility.Collapsed;
            nucoinide.Visibility = Visibility.Collapsed;
        }

        private void Inapoi_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = null;
            this.Content = null;
            PagPrincipala pag = new PagPrincipala();
            mainFrame.NavigationService.Navigate(pag);
        }

        private void confirmareparola_PasswordChanged(object sender, RoutedEventArgs e)
        {
            existent.Visibility = Visibility.Collapsed;
            nucoinide.Visibility = Visibility.Collapsed;
        }

        private void parola_PasswordChanged(object sender, RoutedEventArgs e)
        {
            existent.Visibility = Visibility.Collapsed;
            nucoinide.Visibility = Visibility.Collapsed;
        }

        private void email_TextChanged(object sender, TextChangedEventArgs e)
        {
            existent.Visibility = Visibility.Collapsed;
            nucoinide.Visibility = Visibility.Collapsed;
        }

        private void prenume_TextChanged(object sender, TextChangedEventArgs e)
        {
            existent.Visibility = Visibility.Collapsed;
            nucoinide.Visibility = Visibility.Collapsed;
        }
    }
}
