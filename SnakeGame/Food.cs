using System;
using System.Drawing;

namespace SnakeGame
{
    class Food
    {
        public Rectangle Piece;
        private int x, y, width = 10, height = 10;

        public Food(Random rand)
        {
            Generate(rand);
            Piece = new Rectangle(x, y, width, height);
        }

        public void Draw(Graphics graphics)
        {
            Piece.X = x;
            Piece.Y = y;
            graphics.FillRectangle(Brushes.Black, Piece);
        }

        public void Generate(Random rand)
        {
            x = rand.Next(0, 30) * 10;
            y = rand.Next(0, 20) * 10;

        }
    }
}
