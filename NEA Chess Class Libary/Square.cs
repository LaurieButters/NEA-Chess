﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_Chess_Class_Libary
{
    public enum Row { A,B,C,D,E,F,G,H}
    public class Square
    {
        private Row row;
        private int column;
        private bool isWhite;
        private Piece piece;

        public void Reset()
        {

        }
    }
}
