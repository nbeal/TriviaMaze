using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{

    //This Class holds the data and is sent to the BinarySerialization Class to be saved.
    [Serializable]
    public class Save
    {
        public Room[] rooms;

        public int roomID;

        public int difficulty;
    }
}
