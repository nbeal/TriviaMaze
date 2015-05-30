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
    public partial class Maze : Form
    {

        private int roomID = 5;

        public Maze()
        {
            InitializeComponent();
        }

        private void WestLabel_Click(object sender, EventArgs e)
        {

        }

        private void mapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Map map = new Map(roomID);
            map.Show();
        }
    }
}
