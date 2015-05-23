using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication4
{
    public partial class TriviaMaze : Form
    {
        public TriviaMaze()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void StartScreen_Click(object sender, EventArgs e)
        {

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartScreen.Visible = false;
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutUs us = new AboutUs();
            us.Show();
        }
    }
}
