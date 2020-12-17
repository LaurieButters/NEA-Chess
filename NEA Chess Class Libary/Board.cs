using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_Chess_Class_Libary
{
    public enum Row { A, B, C, D, E, F, G, H }
    public class Board
    {
        private Square[] board;

        public Board()
        {
            int counter = 0;
            bool isWhite = false; 
            Row row;
            for (int i = 0;i < 8; row++)
            {
                if (i == 0)
                {
                    row = Row.A;
                }
                else if (i == 1)
                {
                    row = Row.B;
                }
                else if (i == 2)
                {
                    row = Row.C;
                }
                else if (i == 3)
                {
                    row = Row.D;
                }
                else if (i == 4)
                {
                    row = Row.E;
                }
                else if (i == 5)
                {
                    row = Row.F;
                }
                else if (i == 6)
                {
                    row = Row.G;
                }
                else
                {
                    row = Row.H;
                }
                for (int column = 1; column < 9; column++)
                {
                    Square temp = new Square(row, column, isWhite);
                    isWhite = !isWhite;
                    board[counter] = temp;
                    counter++;                    
                }
            }
        }

        public void Reset()
        {
            
        }
    }
}
