using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using TicTacToe.Resources;

namespace TicTacToe
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

        }
        private void Image_Loaded(object sender, RoutedEventArgs e)
        {
            string url_pvsp;
            string url_pvsc;
            if (Design.Black() != true)
            {
                url_pvsp = "/Assets/Tiles/player_vs_player_black.png";
                url_pvsc = "/Assets/Tiles/player_vs_computer_black.png";
            }
            else
            {
                url_pvsp = "/Assets/Tiles/player_vs_player_white.png";
                url_pvsc = "/Assets/Tiles/player_vs_computer_white.png";
            }
            
            Uri imageUri = new Uri(url_pvsp, UriKind.Relative);
            pvsp.Source = new BitmapImage(imageUri);
            imageUri = new Uri(url_pvsc, UriKind.Relative);
            pvsc.Source = new BitmapImage(imageUri);
        }

        private void pvsp_Tap(object sender, System.Windows.Input.GestureEventArgs e)//Player vs Player
        {
            NavigationService.Navigate(new Uri("/pvsp.xaml", UriKind.Relative));
        }
        private void pvsc_Tap(object sender, RoutedEventArgs e)//Player vs Computer
        {
            NavigationService.Navigate(new Uri("/pvsc.xaml", UriKind.Relative));
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/About.xaml", UriKind.Relative));
        }
    }
}