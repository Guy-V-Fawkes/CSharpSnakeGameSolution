using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpSnakeGame
{
    public partial class PlayGround : Form
    {
        Random randFood = new Random();
        Graphics graphics;
        Snake snake = new Snake();
        Food food;
        public int Score = 000;
        
        

        bool left = false;
        bool right = true;
        bool up = false;
        bool down = false;




        public PlayGround()
        {
            InitializeComponent();
            food = new Food(randFood);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            food.DrawFood(graphics);
            snake.DrawSnake(graphics);
            

            for (int i = 0; i < snake.SnakeBody1.Length; i++)
            {
                if (snake.SnakeBody1[i].IntersectsWith(food.FoodBody))
                {
                    food.FoodLocation(randFood);
                }
                Collision();
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
            {
                GameTimer.Enabled = true;
                GameOverLabel.Text = "";
                left = false;
                right = true;
                up = false;
                down = false;

            }
            if (e.KeyData == Keys.Down && up == false)
            {
                down = true;
                up = false;
                left = false;
                right = false;

            }
            if (e.KeyData == Keys.Up && down == false)
            {
                down = false;
                up = true;
                left = false;
                right = false;
            }
            if (e.KeyData == Keys.Left && right == false)
            {
                down = false;
                up = false;
                left = true;
                right = false;
            }
            if (e.KeyData == Keys.Right && left == false)
            {
                down = false;
                up = false;
                left = false;
                right = true;
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            GameOverLabel.Text = "";
            ScoreLabel.Text = Convert.ToString(Score);
            if (down) { snake.MoveDown(); }
            if (up) { snake.MoveUp(); }
            if (left) { snake.MoveLeft(); }
            if (right) { snake.MoveRight(); }

            for (int i = 0; i < snake.SnakeBody1.Length; i++)
            {
                if (snake.SnakeBody1[i].IntersectsWith(food.FoodBody))
                {

                    snake.GrowSnake();
                    Score += 100;
                    food.FoodLocation(randFood);
                    if (GameTimer.Interval > 50)
                    {
                        GameTimer.Interval = GameTimer.Interval -= 5;
                    }
                }

            }
            this.Invalidate();
        }
        public void Collision()
        {
            for (int i = 1; i < snake.SnakeBody1.Length; i++)
            {
                if (snake.SnakeBody1[0].IntersectsWith(snake.SnakeBody1[i]))
                {
                    Restart();
                }

            }
            if (snake.SnakeBody1[0].X < 0 || snake.SnakeBody1[0].X > 350)
            {
                Restart();
            }
            if (snake.SnakeBody1[0].Y < 0 || snake.SnakeBody1[0].Y > 320)
            {
                Restart();
            }

        }
        public void Restart()
        {
            GameTimer.Enabled = false;
            GameOverLabel.Text = "Game Over\n" + "Your Score is: "+ Score +"\n Press SPACE to play again"+"\n Designed by Jim Kritikos";
            ScoreLabel.Text = "000";
            Score = 000;
            snake = new Snake();
            GameTimer.Interval = 150;
        }
    }
}
