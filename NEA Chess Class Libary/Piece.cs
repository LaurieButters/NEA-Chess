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
        private bool isCaptured;
        private bool isPinned;

        public virtual void Move()
        {

        }
        public virtual void Remove()
        {

        }
        public virtual void VaildMoves()
        {

        }
        public virtual bool CanBeCaptured()
        {

        }
        public virtual bool CheckForCheck()
        {

        }
        public virtual bool IsPinned()
        {

        }
    }

    public class King : Piece
    {
        private bool hasMoved;

        public void Castle()
        {

        }
        public bool CheckCastleIsValid()
        {

        }
    }
    public class Rook : Piece
    {
        private bool hasMoved;
        
    }
    public class Pawn : Piece
    {
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
