using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    static class ShapesHandler
    {
        private static Shape[] shapesArray;

        static ShapesHandler()
        {
            shapesArray = new Shape[]
                {
                    new Shape {
                        Width = 2,
                        Height = 2,
                        Dots = new int[,]
                        {
                            { 1, 1 },
                            { 1, 1 }
                        }
                    },
                    new Shape {
                        Width = 1,
                        Height = 4,
                        Dots = new int[,]
                        {
                            { 1 },
                            { 1 },
                            { 1 },
                            { 1 }
                        }
                    },
                    new Shape {
                        Width = 3,
                        Height = 2,
                        Dots = new int[,]
                        {
                            { 0, 1, 0 },
                            { 1, 1, 1 }
                        }
                    },
                    new Shape {
                        Width = 3,
                        Height = 2,
                        Dots = new int[,]
                        {
                            { 0, 0, 1 },
                            { 1, 1, 1 }
                        }
                    },
                    new Shape {
                        Width = 3,
                        Height = 2,
                        Dots = new int[,]
                        {
                            { 1, 0, 0 },
                            { 1, 1, 1 }
                        }
                    },
                    new Shape {
                        Width = 3,
                        Height = 2,
                        Dots = new int[,]
                        {
                            { 1, 1, 0 },
                            { 0, 1, 1 }
                        }
                    },
                    new Shape {
                        Width = 3,
                        Height = 2,
                        Dots = new int[,]
                        {
                            { 0, 1, 1 },
                            { 1, 1, 0 }
                        }
                    }
            };
        }

        public static Dictionary<int, Brush> ColorsForShape = new Dictionary<int, Brush>()
            {
                {1, Brushes.Green },
                {2, Brushes.Yellow },
                {3, Brushes.Red },
                {4, Brushes.Orange },
                {5, Brushes.Blue },
                {6, Brushes.Black },
                {7, Brushes.White }
            };

        public static Shape GetRandomShape()
        {
            int shapeColorNumber = new Random().Next(1, ColorsForShape.Count);
            Shape prototypeOfShape = shapesArray[new Random().Next(shapesArray.Length)];
            Shape shape = new Shape
            {
                Width = prototypeOfShape.Width,
                Height = prototypeOfShape.Height,
                Dots = (int[,])prototypeOfShape.Dots.Clone()
            };
            shape.Color = ColorsForShape[shapeColorNumber];
            for (int i = 0; i < shape.Height; i++)
            {
                for (int j = 0; j < shape.Width; j++)
                {
                    if (shape.Dots[i, j] == 1) shape.Dots[i, j] = shapeColorNumber;
                }
            }
            return shape;
        }
    }
}
