using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_Chess_Class_Libary
{
    

    public class Square
    {
        private Row row;
        private int column;
        private bool isWhite;
        private Piece piece;

        public Square(Row row,int column,bool isWhite)
        {
            this.row = row;
            this.column = column;
            this.isWhite = isWhite;
            this.piece = null;
        }

        public void Reset()
        {

        }
    }
}
