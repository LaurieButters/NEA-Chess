using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_Chess_Class_Libary
{
    public abstract class Piece
    {
        private bool isWhite;
        private bool isPinned;

        public virtual void Move()
        {

        }
        public virtual void Remove()
        {

        }
        public virtual Square[] VaildMoves()
        {

        }

        public virtual bool IsPinned()
        {

        }
    }

    public class King : Piece
    {
        private bool hasMoved;

        public void Castle(Piece rook)
        {

        }
        public bool CheckCastleIsValid(Piece rook)
        {

        }
    }
    public class Rook : Piece
    {
        private bool hasMoved;
        
    }
    public class Pawn : Piece
    {
        private bool hasMoved;
        private Square skippedSquare;

        public bool CheckForEnPassent()
        {

        }
        public bool CheckForPromotion()
        {

        }
        public void Promote()
        {

        }
    }
}
