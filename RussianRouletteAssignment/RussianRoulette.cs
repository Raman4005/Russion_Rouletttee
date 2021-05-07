using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRouletteAssignment
{
    public partial class frmGame : Form
    {
        // declaring object
        Random rnd = new Random();
        Game obj_game = new Game();
        public frmGame()
        {
            InitializeComponent();
        }

        private void RussianRoulette_Load(object sender, EventArgs e)
        //saying hello to the user when they load the game form
        {
            lblHello.Text = "Hello " + frmMenu.userName + "!" + "\nAre you ready for some Russian Roulette?";
            SoundPlayer audio = new SoundPlayer(RussianRouletteAssignment.Properties.Resources.myNameIsBond);
            audio.Play();
        }

        private void btnBulletLoad_Click(object sender, EventArgs e)
        // chooses random number for where the bullet isand disables the button so you cannot load more than one bullet
        {
            btnBulletLoad.Text = "LOADED!";
            obj_game.load();
            btnBulletLoad.Enabled = false;
            btnChamberSpin.Enabled = true;
            lblScore.Text = "Your score: " + obj_game.score;
            lblAimAwayChances.Text = "Aim away chances left: " + obj_game.aimAwayChances;
            //code to play sound on button click 
            SoundPlayer audio = new SoundPlayer(RussianRouletteAssignment.Properties.Resources.AmmoCasing);
            audio.Play();

        }

        private void btnChamberSpin_Click(object sender, EventArgs e)
        {
            pbAimHead.Enabled = true;
            pbAimAway.Enabled = true;
            //code to play sound on button click
            SoundPlayer audio = new SoundPlayer(RussianRouletteAssignment.Properties.Resources.ChamberSpin);
            audio.Play();

        }

        private void pbAimHead_Click(object sender, EventArgs e)
        {
            if (obj_game.bulletsLeft <= 6 && obj_game.bulletsLeft > 1)  //checks if you have bullets left
            {
                if (obj_game.bulletLoad == obj_game.bulletcount)
                // checking if you shoot youself or get blank shot
                {

                    pbAimHead.Enabled = false;
                    pbAimAway.Enabled = false;
                    btnChamberSpin.Enabled = false;
                    obj_game.bulletsLeft--;
                    lblBulletsLeft.Text = "Shots left: " + obj_game.bulletsLeft;
                    lblShotOrNot.Text = "You were shot! Game over!";
                    btnNextRound.Enabled = false;
                    btnSaveHighScore.Enabled = true;
                    //code to play sound on button click
                    SoundPlayer audio = new SoundPlayer(RussianRouletteAssignment.Properties.Resources.RevolverShot);
                    audio.Play();
                    obj_game.bulletcount = 6;
                    pbAimHead.Image = Properties.Resources.deathImage;
                }
                else if (obj_game.bulletLoad != obj_game.bulletcount)
                //if you survive, goes to next bullet check, changes scores
                {
                    obj_game.bulletsLeft = obj_game.bulletsLeft - 1;
                    lblBulletsLeft.Text = "Shots left: " + obj_game.bulletsLeft;
                    obj_game.bulletcount = obj_game.bulletcount + 1;
                    lblShotOrNot.Text = "You survive this one!";
                    obj_game.score = obj_game.score + 100;
                    lblScore.Text = "Your score: " + obj_game.score;
                    //code to play sound on button click
                    SoundPlayer audio = new SoundPlayer(RussianRouletteAssignment.Properties.Resources.dryFire);
                    audio.Play();

                }
            }
            else if (obj_game.bulletsLeft <= 1)
            {
                pbAimHead.Enabled = false;
                pbAimAway.Enabled = false;
                btnChamberSpin.Enabled = false;
                obj_game.bulletsLeft = obj_game.bulletsLeft - 1;
                lblBulletsLeft.Text = "Shots left: " + obj_game.bulletsLeft;
                lblShotOrNot.Text = "You were shot! Game over!";
                btnNextRound.Enabled = false;
                btnSaveHighScore.Enabled = true;
                //code to play sound on button click
                SoundPlayer audio = new SoundPlayer(RussianRouletteAssignment.Properties.Resources.RevolverShot);
                audio.Play();
                pbAimHead.Image = Properties.Resources.deathImage;
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        //restarts the game round, setting your score to zero
        {
            btnBulletLoad.Text = "Load Bullet";
            btnNextRound.Enabled = false;
            btnBulletLoad.Enabled = true;
            btnChamberSpin.Enabled = false;
            obj_game.score = 0;
            lblScore.Text = "Your score: " + obj_game.score;
            obj_game.aimAwayChances = 2;
            lblAimAwayChances.Text = "Aim away chances left: " + obj_game.aimAwayChances;
            obj_game.bulletsLeft = 6;
            obj_game.bulletcount = 0;
            lblBulletsLeft.Text = "Shots left: " + obj_game.bulletsLeft;
            obj_game.round = 1;
            lblRound.Text = "Round: " + obj_game.round;
            lblShotOrNot.Text = "";
            pbAimHead.Image = Properties.Resources.pokerFace2;
            pbAimAway.Image = Properties.Resources.aimAway;
            pbAimHead.Enabled = false;
            pbAimAway.Enabled = false;
        }

        private void btnNextRound_Click(object sender, EventArgs e)
        // starts next round (only enabled if you won previous)
        {
            btnBulletLoad.Text = "Load Bullet";
            btnBulletLoad.Enabled = true;
            btnChamberSpin.Enabled = false;
            obj_game.bulletLoad = rnd.Next(1, 7);
            lblScore.Text = "Your score: " + obj_game.score;
            obj_game.aimAwayChances = 2;
            lblAimAwayChances.Text = "Aim away chances left: " + obj_game.aimAwayChances;
            obj_game.bulletsLeft = 6;
            lblBulletsLeft.Text = "Bullets left: " + obj_game.bulletsLeft;
            obj_game.round = obj_game.round + 1;
            lblRound.Text = ("Round: " + obj_game.round);
            pbAimAway.Image = Properties.Resources.aimAway;
            pbAimHead.Enabled = false;
            pbAimAway.Enabled = false;
            btnNextRound.Enabled = false;

        }

        private void btnSaveHighScore_Click(object sender, EventArgs e)
        //saving the high score
        {
            try
            {
                using (StreamWriter writer = File.AppendText(System.AppDomain.CurrentDomain.BaseDirectory + "HighScores.txt"))
                {
                    writer.WriteLine(frmMenu.userName + "|" + obj_game.score);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The file could not be written: " + ex);
            }
            btnSaveHighScore.Enabled = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenu f1 = new frmMenu();
            f1.Show();
            this.Close();
        }

        private void pbAimAway_Click(object sender, EventArgs e)
        {
            if (obj_game.aimAwayChances == 1)
            //disables the aim away button if you have used it twice and sets your next shot to kill you            
            {
                pbAimAway.Enabled = false;
                obj_game.bulletLoad = obj_game.bulletcount; //setting bullet load and bullet count as the same so you lose on next shot
                lblAimAwayChances.Text = "No more chances!";
                pbAimAway.Image = Properties.Resources.noMoreAimAway2;
                obj_game.bulletsLeft = obj_game.bulletsLeft - 1;
                lblBulletsLeft.Text = "Shots left: " + obj_game.bulletsLeft;
                //code to play sound on button click
                SoundPlayer audio = new SoundPlayer(RussianRouletteAssignment.Properties.Resources.dryFire);
                audio.Play();

            }

            else if (obj_game.bulletLoad != obj_game.bulletcount) //checks if you fire a blank away from you
            {
                obj_game.aimAwayChances--;
                lblAimAwayChances.Text = "Aim away chances left: " + obj_game.aimAwayChances;
                lblShotOrNot.Text = "Well that was a waste";
                obj_game.bulletcount = obj_game.bulletcount + 1;
                //code to play sound on button click
                SoundPlayer audio = new SoundPlayer(RussianRouletteAssignment.Properties.Resources.dryFire);
                audio.Play();
                obj_game.bulletsLeft = obj_game.bulletsLeft - 1;
                lblBulletsLeft.Text = "Shots left: " + obj_game.bulletsLeft;

            }
            else if (obj_game.bulletLoad == obj_game.bulletcount)
            // checks if you shoot away from you
            {
                obj_game.aimAwayChances--;
                lblAimAwayChances.Text = "Aim away chances left: " + obj_game.aimAwayChances;
                obj_game.score = obj_game.score + 500;
                btnBulletLoad.Enabled = false;
                btnChamberSpin.Enabled = false;
                pbAimAway.Enabled = false;
                pbAimHead.Enabled = false;
                btnNextRound.Enabled = true;
                lblShotOrNot.Text = "You win this round!";
                lblScore.Text = "Your score: " + obj_game.score;
                obj_game.bulletcount = obj_game.bulletcount + 1;
                //code to play sound on button click
                SoundPlayer audio = new SoundPlayer(RussianRouletteAssignment.Properties.Resources.BulletPass);
                audio.Play();
                obj_game.bulletsLeft = obj_game.bulletsLeft - 1;
                lblBulletsLeft.Text = "Shots left: " + obj_game.bulletsLeft;
            }
            if (obj_game.bulletsLeft <= 1)
            {
                obj_game.aimAwayChances--;
                lblAimAwayChances.Text = "Aim away chances left: " + obj_game.aimAwayChances;
                obj_game.score = obj_game.score + 500;
                btnBulletLoad.Enabled = false;
                btnChamberSpin.Enabled = false;
                pbAimAway.Enabled = false;
                pbAimHead.Enabled = false;
                btnNextRound.Enabled = true;
                lblShotOrNot.Text = "You win this round!";
                lblScore.Text = "Your score: " + obj_game.score;
                obj_game.bulletcount = obj_game.bulletcount + 1;
                //code to play sound on button click
                SoundPlayer audio = new SoundPlayer(RussianRouletteAssignment.Properties.Resources.BulletPass);
                audio.Play();
                obj_game.bulletsLeft = 0;
                lblBulletsLeft.Text = "Shots left: " + obj_game.bulletsLeft;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string help = System.IO.File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + "help.txt");
            MessageBox.Show(help);
        }


    }
}
