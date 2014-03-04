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
        public int Complexity;//Сложность;
        public int Step;//Количество шагов;
        public int CoutOfWinsO;
        public int CoutOfWinsX;
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
            CoutOfWinsX = 0;
            CoutOfWinsO = 0;
            NumOfParts = 0;
            Step = 0;
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
        public string GetWinner(int who)//2-nougth, 1-cross;
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
                if (who == 1)
                {
                    Win = 1;
                    CoutOfWinsX++;
                    return "X";
                }
                else
                {
                    Win = 2;
                    CoutOfWinsO++;
                    return "O";
                }
            }
            else
                return "0";
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
            sender1.Text = "X: " + CoutOfWinsX;
            sender2.Text = "O: " + CoutOfWinsO;
        }
        public string ShowWinner()
        {
            if (Win == 1)
                return "X";
            else
                return "O";
        }
    }
}

