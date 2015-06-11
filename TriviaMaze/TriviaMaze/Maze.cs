using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ConsoleApplication4
{

    public partial class Maze : Form
    {
        #region Initialize

        public Boolean answer;
        private static Room[] rooms;
        private int roomID = 1, loaded, difficulty = 2;
        private static Save save;
        private Boolean won = false;
        private int lockCounter = 0;

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

            if (loaded == 1) //if loading has been requested
            {
                difficulty = save.difficulty;
                roomID = save.roomID;
                rooms = save.rooms;
            }
            else //else load new game
            {
                switch (difficulty)
                {
                    case 1:
                        rooms = scan.scanIn("easy.txt"); //2x2
                        break;
                    case 2:
                        rooms = scan.scanIn("normal.txt");//3x3
                        break;
                    case 3:
                        rooms = scan.scanIn("hard.txt");//4x4
                        break;
                }
            }
            checkDoors();
        }

        #endregion

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

        #region Map

        //Opens Map object depending on difficulty
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

        #endregion

        #region Room Checks

        private void checkGameOver()
        {
            //if both doors leading to winning room are locked
            if (rooms[rooms.Length-1].getNorthDoor().Locked == true && rooms[rooms.Length-1].getWestDoor().Locked == true)
                cueGameOver();
            //If both doors in starter room get locked
            if (rooms[0].getSouthDoor().Locked == true && rooms[0].getEastDoor().Locked == true)
                cueGameOver();

            //if continue to try to open door without changing room, assumes you lost
            if (lockCounter == 5)
                cueGameOver();
           
        }

        private void cueGameOver()
        {
            if (MessageBox.Show("There is no possible ways for you to advance to the end of the maze... Would you like to try again?", "GAME OVER", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                makeNewGame();
            }
            Environment.Exit(0);
        }

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

        //Did the player reach the last room?
        private void checkWin()
        {
            using (var soundPlayer = new SoundPlayer("./Ta Da.wav"))
            {
                soundPlayer.Play();
            }
            won = true;
            if (MessageBox.Show("Congratulations, you win! Would you like to play again?", "Congrats!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                makeNewGame();
            }
            Environment.Exit(0);
        }

        #endregion

        #region Door Buttons

        //Checks door circumstances and if needed gets a question
        private Boolean getQuestion(Door door)
        {
            checkGameOver();
            answer = false;
            if (door.Unlocked)
            {
                lockCounter--;
                return true;
            }
            else if (door.Locked)
            {
                lockCounter++;
                MessageBox.Show("This is door is locked!");
            }
            else
            {
                Question question = new Question(door, this);
                question.Show();//create question gui
                if (answer == true)
                {
                    lockCounter = 0;
                    return true;

                }
                else
                {
                    return false;

                }
            }
            return false;
        }

        private void EastDoor_Click(object sender, EventArgs e)
        {
            
            if (rooms[roomID-1].getEast() != 0)
            {
                if (getQuestion(rooms[roomID - 1].getEastDoor())) //If question answer correctly or unlocked
                {
                    roomID = rooms[roomID - 1].getEastID(); //get next room over
                    rooms[roomID - 1].getWestDoor().Unlocked = true; //set return trip to be unlocked also
                    //MessageBox.Show("" + roomID);//debug
                    checkDoors();
                    if (roomID == (rooms.Length))
                    {
                        checkWin();
                    }
                }
                else//Locks door from otherside
                {
                    checkGameOver();
                    int tempID = rooms[roomID - 1].getEastID();
                    rooms[tempID - 1].getWestDoor().Locked = true;

                }
            }           
        }

        private void SouthDoor_Click(object sender, EventArgs e)
        {
            if (rooms[roomID - 1].getSouth() != 0)
            {
                if (getQuestion(rooms[roomID - 1].getSouthDoor()))
                {
                    roomID = rooms[roomID - 1].getSouthID();
                    rooms[roomID - 1].getNorthDoor().Unlocked = true;
                    //MessageBox.Show("" + roomID);//debug
                    checkDoors();
                    if (roomID == (rooms.Length))
                    {
                        checkWin();
                    }
                }
                else//Locks door from otherside
                {
                    checkGameOver();
                    int tempID = rooms[roomID - 1].getSouthID();
                    rooms[tempID - 1].getNorthDoor().Locked = true;
                }
            }   
        }

        private void NorthDoor_Click(object sender, EventArgs e)
        {
            if (rooms[roomID - 1].getNorth() != 0)
            {
                if (getQuestion(rooms[roomID - 1].getNorthDoor()))
                {

                    roomID = rooms[roomID - 1].getNorthID();
                    rooms[roomID - 1].getSouthDoor().Unlocked = true;
                    //MessageBox.Show("" + roomID);//debug
                    checkDoors();
                    if (roomID == (rooms.Length))
                    {
                        checkWin();
                    }
                }
                else //Locks door from otherside
                {
                    checkGameOver();
                    int tempID = rooms[roomID - 1].getNorthID();
                    rooms[tempID - 1].getSouthDoor().Locked = true;
                }
            }          
        }

        private void WestDoor_Click(object sender, EventArgs e)
        {
            if (rooms[roomID - 1].getWest() != 0)
            {
                if (getQuestion(rooms[roomID - 1].getWestDoor()))
                {
                    roomID = rooms[roomID - 1].getWestID();
                    rooms[roomID - 1].getEastDoor().Unlocked = true;
                    //MessageBox.Show("" + roomID);//debug
                    checkDoors();
                    if (roomID == (rooms.Length))
                    {
                        checkWin();
                    }
                }
                else//Locks door from otherside
                {
                    checkGameOver();
                    int tempID = rooms[roomID - 1].getWestID();
                    rooms[tempID-1].getEastDoor().Locked = true;
                }
                
            }        
        }

        #endregion

        #region Saving

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveGame();
        }

        //Sends data to be saved
        private void saveGame()
        {
            save = new Save();
            save.rooms = this.getRoomArray();
            save.roomID = this.getRoomID();
            save.difficulty = this.difficulty;

            BinarySerialization.WriteToBinaryFile<Save>("\\GameData.bin", save);
            MessageBox.Show("Your game has been saved!");
        }

        #endregion

        #region Closing

        //Opens unseen CMD window to create another Game instance and closes this instance
        private void makeNewGame()
        {
            ProcessStartInfo Info = new ProcessStartInfo();
            Info.Arguments = "/C ping 127.0.0.1 -n 2 && \"" + Application.ExecutablePath + "\"";
            Info.WindowStyle = ProcessWindowStyle.Hidden;
            Info.CreateNoWindow = true;
            Info.FileName = "cmd.exe";
            Process.Start(Info);
            Application.Exit();
        }

        
        private void endGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save changes your game before closing?", "Save Game", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                saveGame();
            }
            Environment.Exit(0);
        }

        //Checks if they would like to save before quitting
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
        #endregion
    }
}
