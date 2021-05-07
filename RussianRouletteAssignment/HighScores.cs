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
    public partial class frmHighScores : Form
    {
        public frmHighScores()
        {
            InitializeComponent();
        }

        private void btnLoadScores_Click(object sender, EventArgs e)
        {
            DGHighScore.ValueType = typeof(double);  //sets the value type of this datagrid column to double
            //loads the scores from the file, splits them at | and adds them to the datagridview box
            DGVHighScores.Rows.Clear();
            using (StreamReader sr = new StreamReader(System.AppDomain.CurrentDomain.BaseDirectory + "HighScores.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] lineArray = line.Split('|');

                    DGVHighScores.Rows.Add(lineArray[0], Convert.ToDouble(lineArray[1]));
                }
            }
            DGVHighScores.Sort(DGVHighScores.Columns[1], ListSortDirection.Descending); // sorts the scores from high to low         

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearScores_Click(object sender, EventArgs e)
        // clears all the scores from the text file
        {
            File.WriteAllText("HighScores.txt", "");
            DGVHighScores.Rows.Clear();
        }

        private void btnClearSelected_Click(object sender, EventArgs e)   //Clearing selected highscore from the data table, then removing from the actual text file (rewrites the whole file minus the removed scores)
        {
            foreach (DataGridViewRow item in this.DGVHighScores.SelectedRows)
            {
                DGVHighScores.Rows.RemoveAt(item.Index);
            }


            TextWriter sW = new StreamWriter(System.AppDomain.CurrentDomain.BaseDirectory + "HighScores.txt");
            {
                int rowcount = DGVHighScores.Rows.Count;
                for (int i = 0; i < rowcount - 1; i++)
                {

                    sW.WriteLine(DGVHighScores.Rows[i].Cells[0].Value.ToString() + "|" + DGVHighScores.Rows[i].Cells[1].Value.ToString());
                }
                sW.Close();
            }
        }
    }
}