using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mines
{
    class Location
    {
        private int X;
        private int Y;

        public Location(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }
    }
}
