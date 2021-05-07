using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRouletteAssignment
{
    public partial class frmMenu : Form
    {
        public static string userName;

        public frmMenu()
        {
            InitializeComponent();          
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (txtName.Text != null)
            {                
                frmGame f2 = new frmGame();
                userName = txtName.Text;
                f2.Show();
            }
        }

        private void btnHighscores_Click(object sender, EventArgs e)
        {
            frmHighScores frmHS = new frmHighScores();
            frmHS.Show();
            
        }

        private void btnExit_Click(object sender, EventArgs e) 
           //closes the app
        {
            Application.Exit();
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)  
            //enables the play button if you have entered a username, disables if there isnothing
        {
            if(txtName.Text != null)
            {
                btnPlay.Enabled = true;
            }
            if (txtName.Text == null)
            {
                btnPlay.Enabled = false;
            }
        }
    }
}


