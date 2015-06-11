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
    public partial class Question : Form
    {
        private Door door;
        private Maze maze;

        public Question(Door passedDoor, Maze passedMaze)
        {
            door = passedDoor;
            maze = passedMaze;

            InitializeComponent();
            QuestionField.Text = door.Question;

            Random random = new Random();
            int answer = random.Next(1, 4);
            if (answer == 1)
            {
                answer1.Text = door.Answer;
                answer2.Text = door.FA1;
                answer3.Text = door.FA2;
                answer4.Text = door.FA3;
            }
            else if (answer == 2)
            {
                answer2.Text = door.Answer;
                answer3.Text = door.FA1;
                answer4.Text = door.FA2;
                answer1.Text = door.FA3;
            }
            else if (answer == 3)
            {
                answer3.Text = door.Answer;
                answer1.Text = door.FA1;
                answer2.Text = door.FA2;
                answer4.Text = door.FA3;
            }
            else if (answer == 4)
            {
                answer4.Text = door.Answer;
                answer1.Text = door.FA1;
                answer2.Text = door.FA2;
                answer3.Text = door.FA3;
            }
        }

        

        private void answer1_Click(object sender, EventArgs e)
        {
            if (answer1.Text == door.Answer)
            {
                door.Unlocked = true;
                sendTrue();
            }
            else
            {
                door.Locked = true;
                sendFalse();
            }

        }

        private void answer2_Click(object sender, EventArgs e)
        {
            if (answer2.Text == door.Answer)
            {
                door.Unlocked = true;
                sendTrue();
            }
            else
            {
                door.Locked = true;
                sendFalse();
            }
        }

        private void answer3_Click(object sender, EventArgs e)
        {
            if (answer3.Text == door.Answer)
            {
                door.Unlocked = true;
                sendTrue();
            }
            else
            {
                door.Locked = true;
                sendFalse();
            }
        }

        private void answer4_Click(object sender, EventArgs e)
        {
            if (answer4.Text == door.Answer)
            {
                door.Unlocked = true;
                sendTrue();
            }
            else
            {
                door.Locked = true;
                sendFalse();
            }
        }

        private void sendTrue()
        {
            maze.answer = true;
            MessageBox.Show("That is right!");
            this.Close();
        }

        private void sendFalse()
        {
            maze.answer = false;
            MessageBox.Show("That is wrong, the door is now locked!");
            this.Close();
        }

    }
}
