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
    public partial class easyMap : Form
    {
        private int roomID = 0;

        public easyMap(int ID)
        {
            InitializeComponent();
            roomID = ID;

            initMap();
            findMap();
        }

        private void initMap()
        {
            map0.Visible = false;
            map1.Visible = false;
            map2.Visible = false;
            map3.Visible = false;
        }

        private void findMap()
        {
            switch (roomID)
            {
                case 1:
                    map1.Visible = true;
                    break;
                case 2:
                    map2.Visible = true;
                    break;
                case 3:
                    map3.Visible = true;
                    break;
                default:
                    map0.Visible = true;
                    break;
            }
        }

        private void easyMap_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
