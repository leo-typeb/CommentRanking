using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace CommentRanking
{
    class Name
    {
        public static SQLiteConnection Open(string filePath)
        {
            return new SQLiteConnection("Data Source=" + filePath + ";Version=3");
        }
        public static Dictionary<string, Dictionary<string, string>> Load(SQLiteConnection con, string cid)
        {
            //
            Dictionary<string, Dictionary<string, string>> name = new Dictionary<string, Dictionary<string, string>> ();
            con.Open();
            try
            {
                string sql = "select id, profilename, permhandlename from user ";
                sql += "where cid = '" + cid + "';";
                SQLiteCommand command = new SQLiteCommand(sql, con);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string id = reader.GetValue(0).ToString();
                        string profilename = reader.GetValue(1).ToString();
                        string permhandlename = reader.GetValue(2).ToString();
                        Dictionary<string, string> userdata = new Dictionary<string, string> ();
                        userdata.Add("profilename", profilename);
                        userdata.Add("permhandlename", permhandlename);
                        name.Add(id, userdata);
                    }
                    reader.Close();
                }
            }
            finally
            {
                con.Close();
            }
            return name;
        }
    }
}

