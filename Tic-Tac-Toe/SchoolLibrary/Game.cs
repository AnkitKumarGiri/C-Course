using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace GameLibrary
{
    public class Game
    {
        public class Cells
        {
            private int[] cells = new int[9];

            public int this[int i]
            {
                get { return cells[i]; }
                set
                {
                    if (cells[i] == -1)
                    {
                        cells[i] = value;
                    }
                    else
                    {
                        throw new Exception("This cell is already taken");
                    }
                }
            }

            public Cells()
            {
                for(int i=0; i<9; i++)
                {
                    cells[i] = -1;
                }
            }

        }

        public Cells Table { get; set; }

        public int Turn { get; set; }
        public Game()
        {
            Table = new Cells();
        }
        
        public void toggleTurn()
        {
            Turn = 1 - Turn;
        }

        public int getWinner()
        {
            // check for row win
            for(int i=0; i<9; i += 3)
            {
                if (Table[i] != -1 && Table[i] == Table[i + 1] && Table[i] == Table[i+2])
                    return Table[i];
            }
            // check for col win
            for(int i=0; i<3; i++)
            {
                if (Table[i] != -1 && Table[i] == Table[i + 3] && Table[i] == Table[i + 6])
                    return Table[i];
            }
            // check for diagonal win
            if (Table[0] != -1 && Table[0] == Table[4] && Table[0] == Table[8])
                return Table[0];
            if (Table[2] != -1 && Table[2] == Table[4] && Table[2] == Table[6])
                return Table[0];

            for(int i = 0; i < 9; i++)
            {
                if (Table[i] == -1) return -1; // game is on
            }
            return 2;//draw
        }
        
    }
}
