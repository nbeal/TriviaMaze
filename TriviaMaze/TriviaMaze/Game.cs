using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ConsoleApplication4
{
    
    public partial class Game : Form
    {
        private Maze maze;
        private Save save;
        private int loaded;
        private int difficulty = 2; //1-easy 2-normal 3-hard

        public Game()
        {
            InitializeComponent();
            resetSQL();

            saveGameToolStripMenuItem.Enabled = false;
            loaded = 0;
        }

        //Sets all question to be "unused" for start of program
        private void resetSQL()
        {
            try
            {
                using (SQLiteConnection myConnection = new SQLiteConnection("Data Source=./MazeQA2.db"))
                {
                    string update = "UPDATE MazeQA SET Used=0";
                    SQLiteCommand updateCmd = new SQLiteCommand(update, myConnection);

                    myConnection.Open();
                    updateCmd.ExecuteNonQuery();
                    myConnection.Close();

                }
            }catch(Exception e)
            {

            }
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void StartScreen_Click(object sender, EventArgs e)
        {

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            saveGameToolStripMenuItem.Enabled = true;
            maze = new Maze(0, save, difficulty);
            maze.Show();
            
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutUs us = new AboutUs();
            us.Show();
        }

        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save = new Save();
            save.rooms = maze.getRoomArray();
            save.roomID = maze.getRoomID();

            BinarySerialization.WriteToBinaryFile<Save>("\\GameData.bin", save);
        }

        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveGameToolStripMenuItem.Enabled = true;
            loaded = 1;
            save = new Save();
            save = BinarySerialization.ReadFromBinaryFile<Save>("\\GameData.bin");
            
            maze = new Maze(loaded, save, difficulty);        
            maze.Show();
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            difficulty = 1;
            MessageBox.Show("Difficulty changed to easy!");
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            difficulty = 2;
            MessageBox.Show("Difficulty changed to medium!");
        }

        private void hardToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            difficulty = 3;
            MessageBox.Show("Difficulty changed to hard!");
        }

    }
}
