using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Room
    {
        private int ID;
        private int north, west, south, east;
        private int nclear, wclear, sclear, eclear;
        private Boolean win = false;

        public int getID()
        {
            return this.ID;
        }

        public void setID(String passed)
        {
            this.ID = Convert.ToInt32(passed);
        }

        public int getExit(String userInput)
        {
        switch(userInput)
		{
			case "north":
				//return getNorth();
			case "west":
				//return getWest();
			case "south":
				//return getSouth();
			case "east":
				//return getEast();
			default:
				Console.WriteLine("Invalid Command");
			break;
		}
		return -1;
    }
    

        public void setExits(String passed)
        {
            //north west south east
            String[] parsed = passed.Split('-');

            north = Convert.ToInt32(passed[0]);
            west = Convert.ToInt32(passed[1]);
            south = Convert.ToInt32(passed[2]);
            east = Convert.ToInt32(passed[3]);
        }

        public void setWin(Boolean passed)
        {
            this.win = passed;
        }

        public Boolean getWin()
        {
            return win;
        }

    }
}
