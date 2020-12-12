using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Shape: ICloneable
    {
        public int Width;
        public int Height;
        public int PositionX;
        public int PositionY;
        public Brush Color;
        public int[,] Dots;
        int[,] backupDots;

        public object Clone()
        {
            return (Shape)MemberwiseClone();
        }

        public void Turn()
        {
            backupDots = Dots;

            Dots = new int[Width, Height];

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Dots[i, j] = backupDots[Height - 1 - j, i];
                }
            }

            var temp = Width;
            Width = Height;
            Height = temp;
        }

        public void RollBack()
        {
            Dots = backupDots;

            var temp = Width;
            Width = Height;
            Height = temp;
        }

        public void Move(int moveDown = 0, int moveSide = 0)
        {
            PositionX += moveSide;
            PositionY += moveDown;
        }
    }
}
