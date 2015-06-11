using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ConsoleApplication4
{
    [Serializable]
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

        //Initial Connection to Database
        public Door()
        {
            int count = getCount();
            Random random = new Random();
            using (SQLiteConnection myConnection = new SQLiteConnection("Data Source=./MazeQA2.db"))
            {
                
                string query = "SELECT * FROM MazeQA WHERE Used=0";// AND ID=" + random.Next(1,count);
                SQLiteCommand cmd = new SQLiteCommand(query, myConnection);
                               
                myConnection.Open();
                
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Question = reader["Question"].ToString();
                        FA1 = reader["FA1"].ToString();
                        FA2 = reader["FA2"].ToString();
                        FA3 = reader["FA3"].ToString();
                        Answer = reader["Answer"].ToString();
                        qId = reader["ID"].ToString();

                    }
                    Update(qId);
                    myConnection.Close();
                    //if (Question == null)
                        //retryQuestion();
                }
            }
            Unlocked = false;
            Locked = false;
        }

        //Attempt to make question grabbing at random, but due to the way it was built would sometimes grab blank questions.
        //Would have liked to finish this portion.
        /*
        private void retryQuestion()
        {
            using (SQLiteConnection myConnection = new SQLiteConnection("Data Source=./MazeQA2.db"))
            {

                string query = "SELECT * FROM MazeQA WHERE Used=0";
                SQLiteCommand cmd = new SQLiteCommand(query, myConnection);

                myConnection.Open();

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Question = reader["Question"].ToString();
                        FA1 = reader["FA1"].ToString();
                        FA2 = reader["FA2"].ToString();
                        FA3 = reader["FA3"].ToString();
                        Answer = reader["Answer"].ToString();
                        qId = reader["ID"].ToString();

                    }
                    Update(qId);
                    myConnection.Close();
                    //if (Question == null)
                      //  retryQuestion();
                }
            }
            Unlocked = false;
            Locked = false;
        }*/

        //Updates what questions have been used already
        private void Update(string qId)
        {
            try
            {
                using (SQLiteConnection myConnection = new SQLiteConnection("Data Source=./MazeQA2.db"))
                {
                    int id = int.Parse(qId);
                    string update = "UPDATE MazeQA SET Used=1 WHERE ID=" + id;
                    SQLiteCommand updateCmd = new SQLiteCommand(update, myConnection);

                    myConnection.Open();
                    updateCmd.ExecuteNonQuery();
                    myConnection.Close();

                }
            }catch(Exception e)
            {

            }
        }

        //Gets count of how many lines in DB
        private int getCount()
        {
            int count;
            using (SQLiteConnection myConnection = new SQLiteConnection("Data Source=./MazeQA2.db"))
            {

                string query = "SELECT COUNT(*) FROM MazeQA";
                SQLiteCommand cmd = new SQLiteCommand(query, myConnection);
                myConnection.Open();
                count = Convert.ToInt32(cmd.ExecuteScalar()); 
                myConnection.Close();
            }
            //MessageBox.Show("" + count); //debug
            return count;
        }
    }
}
