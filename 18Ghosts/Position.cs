﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _18Ghosts
{
    class Position
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}