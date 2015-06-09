using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ConsoleApplication4
{

    public partial class Maze : Form
    {
        private static Room[] rooms;
        private int roomID = 1, loaded, difficulty = 2;
        private static Save save;
        private Boolean won = false;

        public Maze(int passedLoaded, Save passedSave, int passedDifficulty)
        {
            InitializeComponent();
            loaded = passedLoaded;
            save = passedSave;
            difficulty = passedDifficulty;
            InitVars();

        }

        private void InitVars()
        {
            Scan scan = new Scan();

            if (loaded == 1)
            {
                difficulty = save.difficulty;
            }
            switch (difficulty)
            {
                case 1: rooms = scan.scanIn("easy.txt");
                break;
                case 2: rooms = scan.scanIn("normal.txt");
                break;
                case 3: rooms = scan.scanIn("hard.txt");
                break;
            }
            if (loaded == 1)
            {
                roomID = save.roomID;
            }
            checkDoors();
        }

        private void checkWin()
        {
            won = true;
            if (MessageBox.Show("Congratulations, you win! Would you like to play again?", "Congrats!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ProcessStartInfo Info = new ProcessStartInfo();
                Info.Arguments = "/C ping 127.0.0.1 -n 2 && \"" + Application.ExecutablePath + "\"";
                Info.WindowStyle = ProcessWindowStyle.Hidden;
                Info.CreateNoWindow = true;
                Info.FileName = "cmd.exe";
                Process.Start(Info);
                Application.Exit();
            }
            Environment.Exit(0);
        }

        #region get/set

        public Room[] getRoomArray()
        {
            return rooms;
        }

        public int getRoomID()
        {
            return roomID;
        }

        public void setRoomArray(Room[] passedRooms)
        {
            rooms = passedRooms;
        }

        public void setRoomID(int passedID)
        {
            roomID = passedID;
        }

        #endregion

        private void WestLabel_Click(object sender, EventArgs e)
        {

        }

        private void mapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(difficulty == 1)
            {
                easyMap easy = new easyMap(roomID);
                easy.Show();
            }
            else if (difficulty == 2)
            {
                normalMap normal = new normalMap(roomID);
                normal.Show();
            }
            else
                MessageBox.Show("No Map for hard mode! That'd be too easy!");
        }

        #region Image Checks

        private void checkDoors()  //Checks if there is valid door choices in room
        {
            int north, south, east, west;


            if (rooms[roomID - 1].getEast() == 0)
            {
                EastDoor.Visible = false;
                EastLabel.Visible = false;
                east = 0;
            }
            else
            {
                EastDoor.Visible = true;
                EastLabel.Visible = true;
                east = 1;
            }
            //------------------------------------
            if (rooms[roomID - 1].getNorth() == 0)
            {
                NorthDoor.Visible = false;
                NorthLabel.Visible = false;
                north = 0;
            }
            else
            {
                NorthDoor.Visible = true;
                NorthLabel.Visible = true;
                north = 1;
            }
            //------------------------------------
            if (rooms[roomID - 1].getSouth() == 0)
            {
                SouthDoor.Visible = false;
                SouthLabel.Visible = false;
                south = 0;
            }
            else
            {
                SouthDoor.Visible = true;
                SouthLabel.Visible = true;
                south = 1;
            }
            //------------------------------------
            if (rooms[roomID - 1].getWest() == 0)
            {
                WestDoor.Visible = false;
                WestLabel.Visible = false;
                west = 0;
            }
            else
            {
                WestDoor.Visible = true;
                WestLabel.Visible = true;
                west = 1;
            }
            checkRoom(north, south, west, east);
        }

        private void checkRoom(int north, int south, int west, int east) //Changes image of main room in center
        {
            DungeonMap1.Visible = false;
            DungeonMap2.Visible = false;
            DungeonMap3.Visible = false;
            DungeonMap4.Visible = false;
            DungeonMap5.Visible = false;
            DungeonMap6.Visible = false;
            DungeonMap7.Visible = false;
            DungeonMap8.Visible = false;
            DungeonMap9.Visible = false;

            if (north == 0 && south == 1 && west == 0 && east == 1)
                DungeonMap1.Visible = true;
            if (north == 0 && south == 1 && west == 1 && east == 1)
                DungeonMap2.Visible = true;
            if (north == 0 && south == 1 && west == 1 && east == 0)
                DungeonMap3.Visible = true;
            if (north == 1 && south == 1 && west == 0 && east == 1)
                DungeonMap4.Visible = true;
            if (north == 1 && south == 1 && west == 1 && east == 1)
                DungeonMap5.Visible = true;
            if (north == 1 && south == 1 && west == 1 && east == 0)
                DungeonMap6.Visible = true;
            if (north == 1 && south == 0 && west == 0 && east == 1)
                DungeonMap7.Visible = true;
            if (north == 1 && south == 0 && west == 1 && east == 1)
                DungeonMap8.Visible = true;
            if (north == 1 && south == 0 && west == 1 && east == 0)
                DungeonMap9.Visible = true;
        }

        #endregion
      

        private void EastDoor_Click(object sender, EventArgs e)
        {
            
            if (rooms[roomID-1].getEast() != 0)
            {
                 //QUESTION DIALOG <<<<<<<<<<<<<<<<<<<<<<<<-------------------------------------------------------------HERE!
                 roomID = rooms[roomID-1].getEastID();
                 MessageBox.Show("" + roomID);
                 checkDoors();
                 if (roomID == (rooms.Length))
                 {
                     checkWin();
                 }
            }
            
        }

        private void SouthDoor_Click(object sender, EventArgs e)
        {
            if (rooms[roomID - 1].getSouth() != 0)
            {
                //QUESTION DIALOG <<<<<<<<<<<<<<<<<<<<<<<<-------------------------------------------------------------HERE!
                roomID = rooms[roomID-1].getSouthID();
                MessageBox.Show("" + roomID);
                checkDoors();
                if (roomID == (rooms.Length))
                {
                    checkWin();
                }
            }
            
        }

        private void NorthDoor_Click(object sender, EventArgs e)
        {
            if (rooms[roomID - 1].getNorth() != 0)
            {
                //QUESTION DIALOG <<<<<<<<<<<<<<<<<<<<<<<<-------------------------------------------------------------HERE!
                roomID = rooms[roomID-1].getNorthID();
                MessageBox.Show("" + roomID);
                checkDoors();
                if (roomID == (rooms.Length))
                {
                    checkWin();
                }
            }
            
        }

        private void WestDoor_Click(object sender, EventArgs e)
        {
            if (rooms[roomID - 1].getWest() != 0)
            {
                //QUESTION DIALOG <<<<<<<<<<<<<<<<<<<<<<<<-------------------------------------------------------------HERE!
                roomID = rooms[roomID-1].getWestID();
                MessageBox.Show("" + roomID);
                checkDoors();
                if (roomID == (rooms.Length))
                {
                    checkWin();
                }
            }
            
        }

        private void DungeonMap_Click(object sender, EventArgs e)
        {

        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveGame();
        }

        private void saveGame()
        {
            save = new Save();
            save.rooms = this.getRoomArray();
            save.roomID = this.getRoomID();
            save.difficulty = this.difficulty;

            BinarySerialization.WriteToBinaryFile<Save>("\\GameData.bin", save);
            MessageBox.Show("Your game has been saved!");
        }




        private void endGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save changes your game before closing?", "Save Game", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                saveGame();
            }
            Environment.Exit(0);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!won)
            {
                base.OnFormClosing(e);
                if (MessageBox.Show("Do you want to save changes your game before closing?", "Save Game", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    e.Cancel = true;
                    saveGame();
                    Environment.Exit(0);
                }
                Environment.Exit(0);
            }
        }
    }
}
