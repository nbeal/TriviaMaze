using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.IO;

namespace ConsoleApplication4
{
    public class Door
    {
        public string Question { get; set; }
        public string FA1 { get; set; }
        public string FA2 { get; set; }
        public string FA3 { get; set; }
        public string Answer { get; set; }
        public string qId { get; set; }
        public bool Unlocked { get; set; }
        public bool Locked { get; set; }


      

        public Door CreateDoor()
        {
            Door newDoor = new Door();

            using (SQLiteConnection myConnection = new SQLiteConnection("data source=MazeQA2.db"))
            {
                string query = "SELECT * FROM MazeQA WHERE Used=0";
                SQLiteCommand cmd = new SQLiteCommand(query, myConnection);
                
                myConnection.Open();
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        newDoor.Question = reader["Question"].ToString();
                        newDoor.FA1 = reader["FA1"].ToString();
                        newDoor.FA2 = reader["FA2"].ToString();
                        newDoor.FA3 = reader["FA3"].ToString();
                        newDoor.Answer = reader["Answer"].ToString();
                        newDoor.qId = reader["ID"].ToString();
                    }
                    Update(newDoor.qId);
                    myConnection.Close();
                }
            }
            newDoor.Unlocked = true;
            newDoor.Locked = true;
            
            return newDoor;
        }

        public void Update(string qId)
        {
            using (SQLiteConnection myConnection = new SQLiteConnection("data source=MazeQA2.db"))
            {
                int id = int.Parse(qId);
                string update = "UPDATE MazeQA SET Used=1 WHERE ID=@id";
                SQLiteCommand updateCmd = new SQLiteCommand(update, myConnection);

                myConnection.Open();
                updateCmd.ExecuteNonQuery();
                myConnection.Close();
                
            }
        }
    }
}
