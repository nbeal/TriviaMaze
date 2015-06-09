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
    public partial class normalMap : Form
    {
        private int roomID = 0, difficulty;

        public normalMap(int ID)
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
            map4.Visible = false;
            map5.Visible = false;
            map6.Visible = false;
            map7.Visible = false;
            map8.Visible = false;
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
                case 4:
                    map4.Visible = true;
                    break;
                case 5:
                    map5.Visible = true;
                    break;
                case 6:
                    map6.Visible = true;
                    break;
                case 7:
                    map7.Visible = true;
                    break;
                case 8:
                    map8.Visible = true;
                    break;
                default:
                    map0.Visible = true;
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
