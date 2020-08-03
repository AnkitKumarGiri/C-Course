using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLibrary;

namespace Board
{
    public partial class Display : Form
    {
        Game newgame;
        int winner;
        public Display()
        {
            InitializeComponent();
            newgame = new Game();
            winner = -1;
        }

        private void render()
        {
            winner = newgame.getWinner();
            if (winner == -1)
                dispTurn.Text = newgame.Turn == 0 ? "O" : "X";
            else
            {
                dispMain.Text = winner == 2 ? "Match is Drawn " : "Winner: ";
                dispTurn.Text = winner == 2 ? "" : winner == 0 ? "O" : "X";
            }
            cell1.Text = newgame.Table[0] == -1 ? "-" : newgame.Table[0] == 0 ? "O" : "X";
            cell2.Text = newgame.Table[1] == -1 ? "-" : newgame.Table[1] == 0 ? "O" : "X";
            cell3.Text = newgame.Table[2] == -1 ? "-" : newgame.Table[2] == 0 ? "O" : "X";
            cell4.Text = newgame.Table[3] == -1 ? "-" : newgame.Table[3] == 0 ? "O" : "X";
            cell5.Text = newgame.Table[4] == -1 ? "-" : newgame.Table[4] == 0 ? "O" : "X";
            cell6.Text = newgame.Table[5] == -1 ? "-" : newgame.Table[5] == 0 ? "O" : "X";
            cell7.Text = newgame.Table[6] == -1 ? "-" : newgame.Table[6] == 0 ? "O" : "X";
            cell8.Text = newgame.Table[7] == -1 ? "-" : newgame.Table[7] == 0 ? "O" : "X";
            cell9.Text = newgame.Table[8] == -1 ? "-" : newgame.Table[8] == 0 ? "O" : "X";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("{0} {1} {2}", newgame.Table[0], newgame.Table[1], newgame.Table[2]));
            MessageBox.Show(sb.ToString());
        }

        private void cell1_Click(object sender, EventArgs e)
        {
            if (winner != -1)
            {
                MessageBox.Show("Game is over");
                return;
            }
            try
            {
                newgame.Table[0] = newgame.Turn;
                newgame.toggleTurn();
                render();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cell2_Click(object sender, EventArgs e)
        {
            if (winner != -1)
            {
                MessageBox.Show("Game is over");
                return;
            }
            try
            {
                newgame.Table[1] = newgame.Turn;
                newgame.toggleTurn();
                render();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cell3_Click(object sender, EventArgs e)
        {
            if (winner != -1)
            {
                MessageBox.Show("Game is over");
                return;
            }
            try
            {
                newgame.Table[2] = newgame.Turn;
                newgame.toggleTurn();
                render();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cell4_Click(object sender, EventArgs e)
        {
            if (winner != -1)
            {
                MessageBox.Show("Game is over");
                return;
            }
            try
            {
                newgame.Table[3] = newgame.Turn;
                newgame.toggleTurn();
                render();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cell5_Click(object sender, EventArgs e)
        {
            if (winner != -1)
            {
                MessageBox.Show("Game is over");
                return;
            }
            try
            {
                newgame.Table[4] = newgame.Turn;
                newgame.toggleTurn();
                render();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cell6_Click(object sender, EventArgs e)
        {
            if (winner != -1)
            {
                MessageBox.Show("Game is over");
                return;
            }
            try
            {
                newgame.Table[5] = newgame.Turn;
                newgame.toggleTurn();
                render();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cell7_Click(object sender, EventArgs e)
        {
            if (winner != -1)
            {
                MessageBox.Show("Game is over");
                return;
            }
            try
            {
                newgame.Table[6] = newgame.Turn;
                newgame.toggleTurn();
                render();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cell8_Click(object sender, EventArgs e)
        {
            if (winner != -1)
            {
                MessageBox.Show("Game is over");
                return;
            }
            try
            {
                newgame.Table[7] = newgame.Turn;
                newgame.toggleTurn();
                render();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cell9_Click(object sender, EventArgs e)
        {
            if (winner != -1)
            {
                MessageBox.Show("Game is over");
                return;
            }
            try
            {
                newgame.Table[8] = newgame.Turn;
                newgame.toggleTurn();
                render();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
