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
        Square[] board;
        public void CheckSquareAtLocation()
        {

        }

        public Board()
        {
            int counter = 0;
            bool isWhite = false; 
            Row row;
            for (int row = 0;row < 8; row++)
            {
                if (row == 0)
                {
                    row = Row.A;
                }
                else if (row == 1)
                {
                    row = Row.B;
                }
                else if (row == 2)
                {
                    row = Row.C;
                }
                else if (row == 3)
                {
                    row = Row.D;
                }
                else if (row == 4)
                {
                    row = Row.E;
                }
                else if (row == 5)
                {
                    row = Row.F;
                }
                else if (row == 6)
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
