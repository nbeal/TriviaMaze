using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication4
{
    public class Scan
    {
        //Scans in text document depending on difficulty chosen
        public Room[] scanIn(string difficulty)
        {
            string line, stats = "";
            string[] rawData = new string[100];
            int counter = 0;

            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader("./" + difficulty);
                
                while ((line = file.ReadLine()) != null)
                {
                    if (counter == 0) //takes in first line of size of maze
                    {
                        stats = line;
                    }
                    else
                    {
                        rawData[counter - 1] = line;
                    }
                    counter++;
                }
                file.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found!");
                Environment.Exit(0);
            }

            Room[] rooms = convertFile(stats, rawData);
            return rooms;

        }

        //Converts data to Room Object
        private Room[] convertFile(string stats, string[] rawData)
        {
            int size = Convert.ToInt32(stats);

            Room[] rooms = new Room[size];

            for (int x = 0; x < size; x++)
            {
                String[] parsedData = rawData[x].Split(',');
                
                Room room = new Room();
                room.setID(parsedData[0]);
                room.setExits(parsedData[1]);

                if (Convert.ToInt32(parsedData[0]) == (size - 1)) //if winning room
                {
                    room.setWin(true);
                }
                rooms[x] = room;
            }
            return rooms;
        }
    }
}
