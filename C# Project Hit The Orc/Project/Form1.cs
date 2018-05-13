using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Timers;

namespace Project
{
    public partial class Form1 : Form
    {

        private int location;
        private int score;
        private int misses;
        private int ticksec;
        private int tickmilisec;
        private Random rnd = new Random();
        private Label aboutLabel = new Label();
        private Label htpLabel = new Label();
        private Label scoreLabel = new Label();
        private Label timeLabel = new Label();
        private Label missesLabel = new Label();



        public Form1()
        {
            InitializeComponent();
            ticksec = 0;
            tickmilisec = 0;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Hide Unneeded Pics & Labels
            scoreLabel.Visible = false;
            missesLabel.Visible = false;
            timeLabel.Visible = false;
            returnToMenuBtn.Visible = false;
            startCountingBtn.Visible = false;
            gameBtn7.Visible = false;
            gameBtn7.Image = null;
            gameBtn8.Visible = false;
            gameBtn8.Image = null;
            gameBtn9.Visible = false;
            gameBtn9.Image = null;
            gameBtn5.Visible = false;
            gameBtn5.Image = null;
            gameBtn6.Visible = false;
            gameBtn6.Image = null;
            gameBtn4.Visible = false;
            gameBtn4.Image = null;
            gameBtn2.Visible = false;
            gameBtn2.Image = null;
            gameBtn1.Visible = false;
            gameBtn1.Image = null;
            gameBtn3.Visible = false;
            gameBtn3.Image = null;
            #endregion
        }

        private void UpdateGameStatus()
        {
            #region Show Game Screen Buttons
            returnToMenuBtn.Visible = true;
            startCountingBtn.Visible = true;
            gameBtn7.Visible = true;
            gameBtn8.Visible = true;
            gameBtn9.Visible = true;
            gameBtn5.Visible = true;
            gameBtn6.Visible = true;
            gameBtn4.Visible = true;
            gameBtn2.Visible = true;
            gameBtn1.Visible = true;
            gameBtn3.Visible = true;
            startGameBtn.Visible = false;
            exitGameBtn.Visible = false;            
            #endregion


            scoreLabel.Visible = true;
            scoreLabel.BackColor = Color.Transparent;
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(288, 380);
            scoreLabel.Text = "Score: " + score.ToString();
            this.Controls.Add(scoreLabel);

            missesLabel.Visible = true;
            missesLabel.BackColor = Color.Transparent;
            missesLabel.AutoSize = true;
            missesLabel.Location = new Point(170, 380);
            missesLabel.Text = "Misses: " + misses.ToString();
            this.Controls.Add(missesLabel);
 
            timeLabel.Visible = true;
            timeLabel.BackColor = Color.Transparent;
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(410, 380);
            timeLabel.Text = "Time: "
                             + ticksec.ToString() 
                             +"." 
                             + tickmilisec.ToString();
            this.Controls.Add(timeLabel);

            if (score == 20)
            {
                timer2.Stop();
                MessageBox.Show("Your Time is :" + ticksec + "." + tickmilisec + "\r\n"
                               + "Your Misses Amount is:" + misses + "\r\n",
                "Results",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                resetGame();
                
            }

            location = rnd.Next(1, 10);

            if (!startCountingBtn.Enabled)
                showPics();
             
                
            
        }
        private void HidePics(int location)
        {
            #region Hide Pics
            if (location == 1)
                gameBtn1.Image = null;
            if (location == 2)
                gameBtn2.Image = null;
            if (location == 3)
                gameBtn3.Image = null;
            if (location == 4)
                gameBtn4.Image = null;
            if (location == 5)
                gameBtn5.Image = null;
            if (location == 6)
                gameBtn6.Image = null;
            if (location == 7)
                gameBtn7.Image = null;
            if (location == 8)
                gameBtn8.Image = null;
            if (location == 9)
                gameBtn9.Image = null;
            #endregion
        }
        private void showPics()
        {
            #region Show Pics
        if (location == 1)
            gameBtn1.Image = global::Project.Properties.Resources._180px_Goblin_face;
        if (location == 2)
            gameBtn2.Image = global::Project.Properties.Resources._180px_Goblin_face;
        if (location == 3)
            gameBtn3.Image = global::Project.Properties.Resources._180px_Goblin_face;
        if (location == 4)
            gameBtn4.Image = global::Project.Properties.Resources._180px_Goblin_face;
        if (location == 5)
            gameBtn5.Image = global::Project.Properties.Resources._180px_Goblin_face;
        if (location == 6)
            gameBtn6.Image = global::Project.Properties.Resources._180px_Goblin_face;
        if (location == 7)
            gameBtn7.Image = global::Project.Properties.Resources._180px_Goblin_face;
        if (location == 8)
            gameBtn8.Image = global::Project.Properties.Resources._180px_Goblin_face;
        if (location == 9)
            gameBtn9.Image = global::Project.Properties.Resources._180px_Goblin_face;
            #endregion
        }

        private void startGameBtn_Click(object sender, EventArgs e)
        {
            #region Disable Game Buttons At Beginning
            gameBtn1.Enabled = false;
            gameBtn2.Enabled = false;
            gameBtn3.Enabled = false;
            gameBtn4.Enabled = false;
            gameBtn5.Enabled = false;
            gameBtn6.Enabled = false;
            gameBtn7.Enabled = false;
            gameBtn8.Enabled = false;
            gameBtn9.Enabled = false;
            htpGameBtn.Enabled = false;
            aboutGameBtn.Enabled = false;
            #endregion
            resetGame();
            UpdateGameStatus();
            startCountingBtn.Enabled = true;
           
        }
        

        private void startTimer()
        {
            this.timer2.Start();
        }

        private void resetGame()
        {
            #region Hide Pics & Buttons
            gameBtn1.Image = null;
            gameBtn2.Image = null;
            gameBtn3.Image = null;
            gameBtn4.Image = null;
            gameBtn5.Image = null;
            gameBtn6.Image = null;
            gameBtn7.Image = null;
            gameBtn8.Image = null;
            gameBtn9.Image = null;

            gameBtn1.Enabled = false;
            gameBtn2.Enabled = false;
            gameBtn3.Enabled = false;
            gameBtn4.Enabled = false;
            gameBtn5.Enabled = false;
            gameBtn6.Enabled = false;
            gameBtn7.Enabled = false;
            gameBtn8.Enabled = false;
            gameBtn9.Enabled = false;
            #endregion
            startCountingBtn.Enabled = true;
            score = 0;
            misses = 0;
            ticksec = 0;
            tickmilisec = 0;
            timer2.Stop();
            UpdateGameStatus();
        }

        private void htpGameBtn_Click(object sender, EventArgs e)
        {
            BackgroundImage = null;
            startGameBtn.Visible = false;
            htpGameBtn.Visible = false;
            aboutGameBtn.Visible = false;
            exitGameBtn.Visible = false;
            returnToMenuBtn.Visible = true;

            htpLabel.Visible = true;
            htpLabel.AutoSize = true;
            htpLabel.Font = new Font(htpLabel.Font.FontFamily, 
                                      13, htpLabel.Font.Style);
            htpLabel.BackColor = Color.Transparent;
            htpLabel.Location = new Point(65,200);
            htpLabel.Text = "The object of the game is to hit 20 monsters as fast as you can. \r\n"
                            +"To hit a monster you need to click it with the mouse \r\n"
                            + "Good Luck!";
            this.Controls.Add(htpLabel);
        }

        private void aboutGameBtn_Click(object sender, EventArgs e)
        {
            BackgroundImage = null;
            startGameBtn.Visible = false;
            htpGameBtn.Visible = false;
            aboutGameBtn.Visible = false;
            exitGameBtn.Visible = false;
            returnToMenuBtn.Visible = true;

            aboutLabel.Visible = true;
            aboutLabel.AutoSize = true;
            aboutLabel.Font = new Font(aboutLabel.Font.FontFamily, 13
                                       , aboutLabel.Font.Style);          
            aboutLabel.BackColor = Color.Transparent;
            aboutLabel.Location = new Point(65,220);
            aboutLabel.Text = "This game was created by Dima Kalinichenko from Yud Alef 8. \r\n"
                              +"Hope youll enjoy this game!" ;
            this.Controls.Add(aboutLabel);
        }

        private void exitGameBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void returnToMenuBtn_Click(object sender, EventArgs e)
        {
            #region Show Menu Buttons Only
            startGameBtn.Visible = true;
            htpGameBtn.Visible = true;
            aboutGameBtn.Visible = true;
            exitGameBtn.Visible = true;
            returnToMenuBtn.Visible = false;
            startCountingBtn.Visible = false;
            aboutGameBtn.Enabled = true;
            htpGameBtn.Enabled = true;
            gameBtn1.Image = null;
            gameBtn2.Image = null;
            gameBtn3.Image = null;
            gameBtn4.Image = null;
            gameBtn5.Image = null;
            gameBtn6.Image = null;
            gameBtn7.Image = null;
            gameBtn8.Image = null;
            gameBtn9.Image = null;
            gameBtn7.Visible = false;
            gameBtn8.Visible = false;
            gameBtn9.Visible = false;
            gameBtn5.Visible = false;
            gameBtn6.Visible = false;
            gameBtn4.Visible = false;
            gameBtn2.Visible = false;
            gameBtn1.Visible = false;
            gameBtn3.Visible = false;
            aboutLabel.Visible = false;
            htpLabel.Visible = false;
            scoreLabel.Visible = false;
            missesLabel.Visible = false;
            timeLabel.Visible = false;
            #endregion
            this.BackgroundImage = global::Project.Properties.Resources.orc_001;
            this.timer2.Stop();
            
        }

        private void gameBtn1_Click(object sender, EventArgs e)
        {
            gameBtn1.Image = null;
            if (location == 1)
                score++;
            else
                misses++;
            HidePics(location);
           
            UpdateGameStatus();
        }

        private void gameBtn2_Click(object sender, EventArgs e)
        {   
            gameBtn2.Image = null;
            if (location == 2)
                score++;
            else
                misses++;
            HidePics(location);

            UpdateGameStatus(); 
        }

        private void gameBtn3_Click(object sender, EventArgs e)
        {
            gameBtn3.Image = null;
            if (location == 3)
                score++;
            else
                misses++;
            HidePics(location);
 
            UpdateGameStatus(); 
        }

        private void gameBtn4_Click(object sender, EventArgs e)
        {
            gameBtn4.Image = null;
            if (location == 4)
                score++;
            else
                misses++;
            HidePics(location);

            UpdateGameStatus(); 
        }

        private void gameBtn5_Click(object sender, EventArgs e)
        {
            gameBtn5.Image = null;
            if (location == 5)
                score++;
            else
                misses++;
            HidePics(location);

            UpdateGameStatus(); 
        }

        private void gameBtn6_Click(object sender, EventArgs e)
        {
            gameBtn6.Image = null;
            if (location == 6)
                score++;
            else
                misses++;
            HidePics(location);

            UpdateGameStatus(); 
        }

        private void gameBtn7_Click(object sender, EventArgs e)
        {
            gameBtn7.Image = null;
            if (location == 7)
                score++;
            else
                misses++;
            HidePics(location);

            UpdateGameStatus(); 
        }

        private void gameBtn8_Click(object sender, EventArgs e)
        {
            gameBtn8.Image = null;
            if (location == 8)
                score++;
            else
                misses++;
            HidePics(location);

            UpdateGameStatus(); 
        }

        private void gameBtn9_Click(object sender, EventArgs e)
        {
            gameBtn9.Image = null;
            if (location == 9)
                score++;
            else
                misses++;
            HidePics(location);

            UpdateGameStatus(); 
        }


        private void timer2_Tick(object sender, EventArgs e)
        {

            tickmilisec += 2;
           
            if (tickmilisec >= 100)
            {
                ticksec += tickmilisec / 100;
                tickmilisec = 0;
            }

            timeLabel.Text = "Time: "
                             + ticksec.ToString()
                             + "."
                             + tickmilisec.ToString();
        }
        private void startCountingBtn_Click(object sender, EventArgs e)
        {
            startTimer();
            startCountingBtn.Enabled = false;
            #region Enable Game Buttons
            gameBtn1.Enabled = true;
            gameBtn2.Enabled = true;
            gameBtn3.Enabled = true;
            gameBtn4.Enabled = true;
            gameBtn5.Enabled = true;
            gameBtn6.Enabled = true;
            gameBtn7.Enabled = true;
            gameBtn8.Enabled = true;
            gameBtn9.Enabled = true;
            #endregion
            showPics();

        }

    }
}