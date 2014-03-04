using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace TicTacToe
{
    public partial class pvsc : PhoneApplicationPage
    {
        public pvsc()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)//easy
        {
            NavigationService.Navigate(new Uri("/pvscpl.xaml?Complexity=1", UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)//medium
        {
            NavigationService.Navigate(new Uri("/pvscpl.xaml?Complexity=2", UriKind.Relative));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)//hard
        {
            NavigationService.Navigate(new Uri("/pvscpl.xaml?Complexity=3", UriKind.Relative));
        }
    }
}