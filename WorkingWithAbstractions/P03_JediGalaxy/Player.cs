﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P03_JediGalaxy
{
    class Player
    {
        private int row;
        private int col;

        public int Col
        {
            get { return col; }
            set { col = value; }
        }

        public int Row
        {
            get { return row; }
            set { row = value; }
        }
    }
}
