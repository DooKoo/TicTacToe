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
    public partial class pvsp : PhoneApplicationPage
    {
        private Game Game1 = new Game();
        private Button[] SetOfButton= new Button[9];//массив кнопок;
        public pvsp()
        {
            InitializeComponent();
        }

        private void On_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            TextMessages.Text = "";
            Button tBut = (Button)sender;
            int id =Convert.ToInt16(tBut.Name[4].ToString());//id клетки;
            int x=0;//координата строки;
            int y=0;//Координата столбца;
            switch(id)//По id клетки ищем координаты;
            {
                case 1: x = 0; y = 0; break;
                case 2: x = 0; y = 1; break;
                case 3: x = 0; y = 2; break;
                case 4: x = 1; y = 0; break;
                case 5: x = 1; y = 1; break;
                case 6: x = 1; y = 2; break;
                case 7: x = 2; y = 0; break;
                case 8: x = 2; y = 1; break;
                case 9: x = 2; y = 2; break;
            }
                        
            if (Game1.GetTable(x, y) == 0 && (Game1.Win == 0) && (Game1.Step < 10)) 
            {
                SetOfButton[Game1.Step] = tBut;//Добавление кнопок в массив;
                tBut.FontSize = 48;

                if (Game1.Step % 2 == Game1.NumOfParts % 2)
                {
                    Game1.MakeStep("X", tBut, x, y);
                }
                else
                {
                    Game1.MakeStep("O", tBut, x, y);
                }
    
                if ((Game1.Win > 0) && (Game1.Step < 9))
                {
                    TextMessages.Text = Game1.ShowWinner() + " выиграл!";                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           
                    Game1.ShowStat(Text1, Text2);
                    Reset.IsEnabled = true;//Видимость кнопки обновления;
                    Reset.Opacity = 1.0;
                    
                }
                else if ((Game1.Win == 0) && (Game1.Step==8))
                {
                    TextMessages.Text = "Ничья";
                    Reset.IsEnabled = true;//Видимость кнопки обновления;
                    Reset.Opacity = 1.0;
                }
                Game1.Step++;
            }                   
                 
        }

        private void Reset_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            
            for (int i = 0; i < Game1.Step; i++)
                SetOfButton[i].Content = "";

            TextMessages.Text = "";
            Reset.IsEnabled = false;//Невидимость кнопки обновления;
            Reset.Opacity = 0.0;
            Game1.ResetGame();
            Game1.NumOfParts++;

            if(Game1.NumOfParts%2==1)
                TextMessages.Text = "O- ваш ход!";
            else
                TextMessages.Text = "X- ваш ход!";
        }

        private void TextMessages_Loaded(object sender, RoutedEventArgs e)
        {
            Design.SetStyleForTextBlock(TextMessages);
            TextMessages.Text = "X- ваш ход!";
        }

        private void Text_Loaded(object sender, RoutedEventArgs e)
        {
            Design.SetStyleForTextBlock(Text1);
            Design.SetStyleForTextBlock(Text2);
            Game1.ShowStat(Text1, Text2);
        }

    }
}