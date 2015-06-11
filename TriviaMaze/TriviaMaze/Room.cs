using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication4
{
    [Serializable]
    public class Room
    {
        private int ID;
        private int north, west, south, east;
        private int northID, westID, southID, eastID;
        private Door northDoor, westDoor, southDoor, eastDoor;
        private Boolean win = false;

        public int getID()
        {
            return this.ID;
        }

        public void setID(String passed)
        {
            this.ID = Convert.ToInt32(passed);
        }

        public void setExits(String passed)
        {
            //north west south east
            String[] parsed = passed.Split('-');
            
            String[] parsedAgain = parsed[0].Split('+');
            north = Convert.ToInt32(parsedAgain[0]);
            northID = Convert.ToInt32(parsedAgain[1]);
            if (north != 0)
            {
                northDoor = new Door();

            }

            parsedAgain = parsed[1].Split('+');
            west = Convert.ToInt32(parsedAgain[0]);
            westID = Convert.ToInt32(parsedAgain[1]);
            if (west != 0)
            {
                westDoor = new Door();

            }

            parsedAgain = parsed[2].Split('+');
            south = Convert.ToInt32(parsedAgain[0]);
            southID = Convert.ToInt32(parsedAgain[1]);
            if (south != 0)
            {
                southDoor = new Door();

            }

            parsedAgain = parsed[3].Split('+');
            east = Convert.ToInt32(parsedAgain[0]);
            eastID = Convert.ToInt32(parsedAgain[1]);
            if (east != 0)
            {
                eastDoor = new Door();

            }
        }

        public void setWin(Boolean passed)
        {
            this.win = passed;
        }

        public Boolean getWin()
        {
            return win;
        }


        #region get Directions

        //--------------------
        public int getNorth()
        {
            return north;
        }
        public int getWest()
        {
            return west;
        }
        public int getSouth()
        {
            return south;
        }
        public int getEast()
        {
            return east;
        }
        //--------------------
        public int getNorthID()
        {
            return northID;
        }
        public int getWestID()
        {
            return westID;
        }
        public int getSouthID()
        {
            return southID;
        }
        public int getEastID()
        {
            return eastID;
        }
        //--------------------
        public Door getNorthDoor()
        {
            return northDoor;
        }
        public Door getWestDoor()
        {
            return westDoor;
        }
        public Door getSouthDoor()
        {
            return southDoor;
        }
        public Door getEastDoor()
        {
            return eastDoor;
        }



        #endregion
    }
}
