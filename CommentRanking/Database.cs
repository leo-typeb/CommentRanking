using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace CommentRanking
{
    class Database
    {
        public static SQLiteConnection Open(string filePath)
        {
            return new SQLiteConnection("Data Source=" + filePath + ";Version=3");
        }
        public static Dictionary<string, string> Load(SQLiteConnection con, string cid, string year)
        {
            Dictionary<string, string> ranking = new Dictionary<string, string>();
            string year_iso8601 = year + "0101T00:00:00Z";
            DateTime start = DateTime.ParseExact(year_iso8601, "yyyyMMddTHH:mm:ssZ",
                                System.Globalization.CultureInfo.InvariantCulture);
            DateTime end = start.AddYears(1);
            string start_serial = start.Ticks.ToString();
            string end_serial = end.Ticks.ToString();
            Console.WriteLine(start_serial);
            Console.WriteLine(end_serial);
            con.Open();
            try
            {
                string sql = "select uid, count(uid) from chat ";
                sql += "where cid = '" + cid + "' and mail <> '184' and uid <> '' ";
                sql += "and date >= " + start_serial + " and date < " + end_serial + " ";
                sql += "group by uid ";
                sql += "order by count(uid) desc;";
                SQLiteCommand command = new SQLiteCommand(sql, con);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string uid = reader.GetValue(0).ToString();
                        string count = reader.GetValue(1).ToString();
                        ranking.Add(uid, count);
                    }
                    reader.Close();
                }
            }
            finally
            {
                con.Close();
            }
            return ranking;
        }
    }
}

