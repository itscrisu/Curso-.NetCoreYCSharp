using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Encapsulacion
{
    public class PointEncapsulado
    {
        private int X;
        private int Y;

        public void SetX(int value)
        {
            if (value < 100)
                X = value;
            else
                throw new ArgumentOutOfRangeException();
        }

        public void SetY(int value)
        {
            if (value > 50)
                Y = value;
            else
                throw new ArgumentOutOfRangeException();
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
