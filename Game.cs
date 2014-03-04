using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace TicTacToe
{
    class Game
    {
        struct Player
        {
            public int CurrentSign;//1-cross, 2-nougth;
            public int CoutOfWins;

        }
        public int Complexity;//Сложность;
        public int Step;//Количество шагов;
        private Player[] Players;
        public int NumOfParts;
        public int Win;//Победитель,0- никто, 2-nougth, 1-cross;
        private int[,] Table= new int[3,3];//0- empty, 2-nougth, 1-cross;
        public Game()
        {
            FullResetGame();
        }

        public void FullResetGame()
        {
            ResetGame();
            Players = new Player[2];
            Players[0].CoutOfWins = 0;//Игрок 1;
            Players[0].CurrentSign = 0;
            Players[1].CoutOfWins = 0;//Игрок 2;
            Players[1].CurrentSign = 0;
            NumOfParts = 0;
        }
        public void ResetGame()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    Table[i,j] = 0;

            Step = 0;
            Win = 0;
                
        }
        public void SetTable(int player, int x, int y)//player: 0-cross, 1-nougth;
        {
            if (player == 0)
                Table[x, y] = 1;//cross;
            else 
                Table[x, y] = 2;//nougth;
        }
        public int GetTable(int x, int y)
        {
            return Table[x, y];
        }
        public void GetWinner(int who)//2-nougth, 1-cross;
        {
            if (
                ((Table[0, 0] == who) && (Table[0, 1] == who) && (Table[0, 2] == who)) ||
                ((Table[1, 0] == who) && (Table[1, 1] == who) && (Table[1, 2] == who)) ||
                ((Table[2, 0] == who) && (Table[2, 1] == who) && (Table[2, 2] == who)) ||
                ((Table[0, 0] == who) && (Table[1, 0] == who) && (Table[2, 0] == who)) ||
                ((Table[0, 1] == who) && (Table[1, 1] == who) && (Table[2, 1] == who)) ||
                ((Table[0, 2] == who) && (Table[1, 2] == who) && (Table[2, 2] == who)) ||
                ((Table[0, 0] == who) && (Table[1, 1] == who) && (Table[2, 2] == who)) ||
                ((Table[0, 2] == who) && (Table[1, 1] == who) && (Table[2, 0] == who)))
            {
                if (1 == who)
                    Win= 1;
                else if(2 == who)
                    Win= 2;
            }
            else
                Win= 0;
            
        }
        public void MakeStep(string sign, Button Butt, int inpX, int inpY)
       {
            
            Butt.Content = sign;
            if (sign == "X")
            {
                SetTable(0, inpX, inpY);
                GetWinner(1);
            }
            else if(sign == "O")
            {
                SetTable(1, inpX, inpY);
                GetWinner(2);
            }
        }
        public void ShowStat(TextBlock sender1, TextBlock sender2)
        {
            sender1.Text = "Игрок 1: " + Players[0].CoutOfWins;
            sender2.Text = "Игрок 2: " + Players[1].CoutOfWins;
        }
        public void CoutOfWinsUp(int sender)
        {
            Players[sender].CoutOfWins++;
        }
        public string GetPlayerSign(int sender)
        {
            if (Players[sender].CurrentSign == 1)
                return "X";
            else
                return "O";
        }
        public void SetPlayerSign(int sender, string input)
        {
            if (input == "X")
                Players[sender].CurrentSign = 1;
            else
                Players[sender].CurrentSign = 2;
        }
    }
}

