using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datorium_PacMan_Maybe
{
    public partial class Game : Form
    {
        int heroStep = 5;
        int enemyStep = 3;
        int verVelocity = 0;
        int horVelocity = 0;
        int verEnemyVelocity = 0;
        int horEnemyVelocity = 0;
        int heroImage = 0;
        int enemyImage = 1;
        int score = 0;

        string enemydirection = "right";
        string herodirection = "right";
        Random Rand = new Random();

        Keys lastKeyCode;


        public Game()
        {
            InitializeComponent();
            SetupGame();
            
        }

        private void SetRandomEnemyDirection()
        {
            int directionCode = Rand.Next(1, 5);
            if (directionCode == 1)
            {
                enemydirection = "right";
                verEnemyVelocity = 0;
                horEnemyVelocity = enemyStep;
            }
            if (directionCode == 2)
            {
                enemydirection = "left";
                verEnemyVelocity = 0;
                horEnemyVelocity = -enemyStep;
            }
            if (directionCode == 3)
            {
                enemydirection = "down";
                verEnemyVelocity = enemyStep;
                horEnemyVelocity = 0;
            }
            if (directionCode == 4)
            {
                enemydirection = "up";
                verEnemyVelocity = -enemyStep;
                horEnemyVelocity = 0;
            }

        }

        private void SetupGame()
        {
            this.BackColor = Color.SkyBlue;

            Hero.BackColor = Color.Transparent;
            Hero.SizeMode = PictureBoxSizeMode.StretchImage;
            Hero.Width = 30;
            Hero.Height = 30;

            UpdateScore();
            Food.BackColor = Color.Transparent;
            Food.SizeMode = PictureBoxSizeMode.StretchImage;
            Food.Image = Properties.Resources.food_1;
            Food.Width = 18;
            Food.Height = 18;

            Enemy.BackColor = Color.Transparent;
            Enemy.Width = 30;
            Enemy.Height = 30;
            Enemy.SizeMode = PictureBoxSizeMode.StretchImage;

            TimerHeroAnimate.Start();
            TimerHeroMove.Start();
            TimerEnemyAnimate.Start();
            TimerEnemyMove.Start();

            
        }

        private void UpdateScore()
        {
            labelScore.Text = "Score:" + score;
        }

        private void HeroFoodCollision()
        {
            if (Hero.Bounds.IntersectsWith(Food.Bounds))
            {
                score += 100;
                RandomizeFood();
                UpdateScore();
                heroStep += 1;
                enemyStep += 1;
            }
        }

        private void RandomizeFood()
        {
            Food.Left = Rand.Next(0, ClientRectangle.Width - Food.Width*2);
            Food.Top = Rand.Next(0, ClientRectangle.Height - Food.Height*2);
            Food.Image = (Image)Properties.Resources.ResourceManager.GetObject("food_" + Rand.Next(1, 5));
        }   
                                              
        private void HeroBorderCollision()
        {          
            if (Hero.Top + Hero.Height < 0)
            {
                Hero.Top = ClientRectangle.Height;
            }

            if (Hero.Left + Hero.Width < 0)
            {
                Hero.Left = ClientRectangle.Width;
            }

            if (Hero.Top > ClientRectangle.Height)
            {
                Hero.Top = 0 - Hero.Height;
            }

            if (Hero.Left > ClientRectangle.Width)
            {
                Hero.Left = 0 - Hero.Width;
            }

        }

        private void HeroEnemyCollision()
        {
            if (Hero.Bounds.IntersectsWith(Enemy.Bounds))
            {
                GameOver();
            }
        }

        private void EnemyBorderCollision()
        {
            if (Enemy.Top < 0)
            {
                enemydirection = "down";
                EnemyBorderBounce();
            }
            else if (Enemy.Top + Enemy.Height > ClientRectangle.Height)
            {
                enemydirection = "up";
                EnemyBorderBounce();
            }
            if (Enemy.Left < 0)
            {
                enemydirection = "right";
                EnemyBorderBounce();
            }
            else if (Enemy.Left + Enemy.Width > ClientRectangle.Width)
            {
                enemydirection = "left";
                EnemyBorderBounce();
            }
        }

        private void EnemyBorderBounce()
        {
            verEnemyVelocity *= -1;
            horEnemyVelocity *= -1;
        }

        private void GameOver()
        {
            TimerHeroMove.Stop();
            TimerEnemyMove.Stop();
            TimerHeroAnimate.Stop();
            TimerEnemyAnimate.Stop();
            TimerHeroMelt.Start();

            
            labelGameOver.ForeColor = Color.White;
            labelGameOver.BackColor = Color.Transparent;
            this.BackColor = Color.Black;
            buttonRestart.Enabled = true;
            labelGameOver.Left = ClientRectangle.Width / 2 - labelGameOver.Width/2;
            labelGameOver.Top = ClientRectangle.Height / 2 - labelGameOver.Top/2;
            buttonRestart.Top = ClientRectangle.Height - buttonRestart.Height*2;
            buttonRestart.Left = ClientRectangle.Width - buttonRestart.Width*2;
            heroImage = 0;

        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                verVelocity = -heroStep;
                horVelocity = 0;
                herodirection = "up";
            }
            else if (e.KeyCode == Keys.Down)
            {
                verVelocity = +heroStep;
                horVelocity = 0;
                herodirection = "down";
            }
            else if (e.KeyCode == Keys.Left)
            {
                horVelocity = -heroStep;
                verVelocity = 0;
                herodirection = "left";
            }
            else if (e.KeyCode == Keys.Right)
            {
                horVelocity = +heroStep;
                verVelocity = 0;
                herodirection = "right";
            }

            if (e.KeyCode == lastKeyCode)
            {
                return;
            }
            if (e.KeyCode == Keys.R)
            {
                Application.Restart();
            }
            lastKeyCode = e.KeyCode;

            SetRandomEnemyDirection();


        }

        private void TimerHeroMove_Tick(object sender, EventArgs e)
        {
            Hero.Top += verVelocity;
            Hero.Left += horVelocity;
            HeroBorderCollision();
            HeroFoodCollision();
            HeroEnemyCollision();
        }

        private void TimerHeroAnimate_Tick(object sender, EventArgs e)
        {
            string heroImageName;
            heroImage++; //heroImage += 1
            heroImageName = "pacman_" + herodirection + "_" + heroImage;
            Hero.Image = (Image)Properties.Resources.ResourceManager.GetObject(heroImageName);
            if (heroImage >= 4)
            {
                heroImage = 0;
            }
        }

        private void TimerEnemyAnimate_Tick(object sender, EventArgs e)
        {
            string enemyImageName;
            enemyImage++;
            enemyImageName = "enemy_" + enemydirection + "_" + enemyImage;
            Enemy.Image = (Image)Properties.Resources.ResourceManager.GetObject(enemyImageName);
            if (enemyImage >= 2)
            {
                enemyImage = 1;
            }
        }

        private void TimerHeroMelt_Tick(object sender, EventArgs e)
        {
            string heroImageName;
            heroImage++; //heroImage += 1
            heroImageName = "pacman_melt_" + heroImage;
            Hero.Image = (Image)Properties.Resources.ResourceManager.GetObject(heroImageName);
            if (heroImage > 14)
            {
                TimerHeroMelt.Stop();
                labelGameOver.Visible = true;
                buttonRestart.Visible = true;
            }
            
        }

        private void TimerEnemyMove_Tick(object sender, EventArgs e)
        {
            Enemy.Top += verEnemyVelocity;
            Enemy.Left += horEnemyVelocity;
            EnemyBorderCollision();
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {            
            Application.Restart();
        }
    }

} //https://online.datorium.eu/courses/coding-apps-with-c-sharp

