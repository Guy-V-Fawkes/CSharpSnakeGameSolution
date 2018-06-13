using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSnakeGame
{
    class Snake
    {
        private Rectangle[] SnakeBody;
        private int x = 150, y = 150, width = 9, height = 9;

        public Rectangle[] SnakeBody1 // Making a public array to return the same array for public use
        {
            get { return SnakeBody; }
        }
        public Snake()
        {
            SnakeBody = new Rectangle[3];


            for (int i = 0; i < SnakeBody.Length; i++)
            {
                SnakeBody[i] = new Rectangle(x, y, width, height);
                x -= 10;

            }
        }
        public void DrawSnake(Graphics graphics)
        {
            foreach (Rectangle body in SnakeBody)
            {
                graphics.FillRectangle(Brushes.Green, body);
            }
        }
        public void DrawSnake()
        {
            for (int i = SnakeBody.Length - 1; i > 0; i--)
            {
                SnakeBody[i] = SnakeBody[i - 1];
            }
        }
        public void MoveDown()
        {
            DrawSnake();
            SnakeBody[0].Y += 10;
        }
        public void MoveUp()
        {
            DrawSnake();
            SnakeBody[0].Y -= 10;
        }
        public void MoveLeft()
        {
            DrawSnake();
            SnakeBody[0].X -= 10;
        }
        public void MoveRight()
        {
            DrawSnake();
            SnakeBody[0].X += 10;
        }
        public void GrowSnake()
        {
            List<Rectangle> body = SnakeBody.ToList();
            body.Add(new Rectangle(SnakeBody[SnakeBody.Length - 1].X, SnakeBody[SnakeBody.Length - 1].Y, width, height));
            SnakeBody = body.ToArray();
        }
    }
}
