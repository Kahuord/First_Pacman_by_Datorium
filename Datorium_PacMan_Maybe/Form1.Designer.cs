namespace Datorium_PacMan_Maybe
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.Hero = new System.Windows.Forms.PictureBox();
            this.Food = new System.Windows.Forms.PictureBox();
            this.Enemy = new System.Windows.Forms.PictureBox();
            this.TimerHeroMove = new System.Windows.Forms.Timer(this.components);
            this.TimerHeroAnimate = new System.Windows.Forms.Timer(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            this.TimerEnemyAnimate = new System.Windows.Forms.Timer(this.components);
            this.TimerHeroMelt = new System.Windows.Forms.Timer(this.components);
            this.TimerEnemyMove = new System.Windows.Forms.Timer(this.components);
            this.labelGameOver = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            this.SuspendLayout();
            // 
            // Hero
            // 
            this.Hero.Location = new System.Drawing.Point(240, 100);
            this.Hero.Name = "Hero";
            this.Hero.Size = new System.Drawing.Size(30, 30);
            this.Hero.TabIndex = 0;
            this.Hero.TabStop = false;
            // 
            // Food
            // 
            this.Food.Location = new System.Drawing.Point(497, 262);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(15, 15);
            this.Food.TabIndex = 0;
            this.Food.TabStop = false;
            // 
            // Enemy
            // 
            this.Enemy.Location = new System.Drawing.Point(570, 141);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(34, 38);
            this.Enemy.TabIndex = 0;
            this.Enemy.TabStop = false;
            // 
            // TimerHeroMove
            // 
            this.TimerHeroMove.Interval = 20;
            this.TimerHeroMove.Tick += new System.EventHandler(this.TimerHeroMove_Tick);
            // 
            // TimerHeroAnimate
            // 
            this.TimerHeroAnimate.Interval = 95;
            this.TimerHeroAnimate.Tick += new System.EventHandler(this.TimerHeroAnimate_Tick);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelScore.Location = new System.Drawing.Point(12, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(16, 18);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "0";
            // 
            // TimerEnemyAnimate
            // 
            this.TimerEnemyAnimate.Interval = 95;
            this.TimerEnemyAnimate.Tick += new System.EventHandler(this.TimerEnemyAnimate_Tick);
            // 
            // TimerHeroMelt
            // 
            this.TimerHeroMelt.Interval = 150;
            this.TimerHeroMelt.Tick += new System.EventHandler(this.TimerHeroMelt_Tick);
            // 
            // TimerEnemyMove
            // 
            this.TimerEnemyMove.Interval = 20;
            this.TimerEnemyMove.Tick += new System.EventHandler(this.TimerEnemyMove_Tick);
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.BackColor = System.Drawing.Color.Transparent;
            this.labelGameOver.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameOver.ForeColor = System.Drawing.Color.Black;
            this.labelGameOver.Location = new System.Drawing.Point(138, 165);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(292, 50);
            this.labelGameOver.TabIndex = 2;
            this.labelGameOver.Text = "PRESS \"F\"";
            this.labelGameOver.Visible = false;
            // 
            // buttonRestart
            // 
            this.buttonRestart.Enabled = false;
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonRestart.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestart.Location = new System.Drawing.Point(629, 274);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(125, 33);
            this.buttonRestart.TabIndex = 3;
            this.buttonRestart.Text = "It is alive!";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Visible = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.labelGameOver);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.Hero);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "Pacman form Datorium";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Hero;
        private System.Windows.Forms.PictureBox Food;
        private System.Windows.Forms.PictureBox Enemy;
        private System.Windows.Forms.Timer TimerHeroMove;
        private System.Windows.Forms.Timer TimerHeroAnimate;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer TimerEnemyAnimate;
        private System.Windows.Forms.Timer TimerHeroMelt;
        private System.Windows.Forms.Timer TimerEnemyMove;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.Button buttonRestart;
    }
}

