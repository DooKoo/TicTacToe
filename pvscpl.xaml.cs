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
    public partial class pvscpl : PhoneApplicationPage
    {
        Game game1= new Game();
   
        public pvscpl()
        {
            InitializeComponent();
        }

        private void StackPanel_Loaded(object sender, RoutedEventArgs e)
        {
            game1.Complexity = Convert.ToInt32(NavigationContext.QueryString["Complexity"]);
        }
   }
}