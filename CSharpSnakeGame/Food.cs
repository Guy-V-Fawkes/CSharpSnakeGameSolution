using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSnakeGame
{
    class Food
    {
        private int x, y, width = 9, height = 9;
        public Rectangle FoodBody;


        public Food(Random randFood)
        {
            x = randFood.Next(0, 35) * 10;
            y = randFood.Next(0, 33) * 10;


            FoodBody = new Rectangle(x, y, width, height);

        }
        public void FoodLocation(Random randFood)
        {
            x = randFood.Next(0, 35) * 10;
            y = randFood.Next(0, 33) * 10;
        }
        public void DrawFood(Graphics graphics)
        {
            FoodBody.X = x;
            FoodBody.Y = y;

            graphics.FillRectangle(Brushes.Red, FoodBody);

        }
    }
}
