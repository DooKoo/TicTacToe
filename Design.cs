using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Media;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace TicTacToe
{
    class Design
    {
         public static bool Black()
        {
            Visibility tmp;
            tmp= (Visibility)Application.Current.Resources["PhoneDarkThemeVisibility"];

            if ("Visible" == tmp.ToString())
                return true;
            else
                return false;
        }
        public static bool White()
        {
            Visibility tmp;
            tmp = (Visibility)Application.Current.Resources["PhoneDarkThemeVisibility"];

            if ("Visible" == tmp.ToString())
                return false;
            else
                return true;
        }
        public static SolidColorBrush GetBrush(string NameOfBrush)
        {
            Color ColorOfBrush=Colors.White;

            if (NameOfBrush == "White")
                ColorOfBrush = Colors.White;
            else if (NameOfBrush == "Black")
                ColorOfBrush = Colors.Black;
            
            SolidColorBrush NewBrush = new SolidColorBrush(ColorOfBrush);
            return NewBrush;
        }
        public static void SetStyleForTextBlock(object sender)
        {
            TextBlock Obj = (TextBlock)sender;

            if (Design.Black() == true)
                Obj.Foreground = Design.GetBrush("White");
            else
                Obj.Foreground = Design.GetBrush("Black");
        }
       }
}
