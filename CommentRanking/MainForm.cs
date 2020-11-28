using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CommentRanking
{
    public partial class MainForm : Form
    {
        private SQLiteConnection database_connection;
        private SQLiteConnection name_connection;
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "ankochan export (*.ansqlite)|*.ansqlite|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                }
            }
            this.database_connection = Database.Open(filePath);
        }

        private void OpenName_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "ankochan export (*.ansqlite)|*.ansqlite|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                }
            }
            this.name_connection = Database.Open(filePath);
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            // clear form
            ListView.Items.Clear();
            string community_id = this.CommunityId.Text;
            string year = this.Year.Text;
            Dictionary<string, string> database = Database.Load(this.database_connection, community_id, year);
            Dictionary<string, Dictionary<string, string>> name = CommentRanking.Name.Load(this.name_connection, community_id);
            int i = 0;
            foreach (KeyValuePair<string, string> record in database)
            {
                try
                {
                    string _name;
                    string _id = record.Key;
                    string comment_count = record.Value;
                    if (name[_id]["permhandlename"] != "")
                    {
                        _name = name[_id]["permhandlename"];
                    }
                    else
                    {
                        _name = name[_id]["profilename"];
                    }
                    ListView.Items.Add((i + 1).ToString());
                    ListView.Items[i].SubItems.Add(_name);
                    ListView.Items[i].SubItems.Add(comment_count);
                    i++;
                }
                catch (System.Collections.Generic.KeyNotFoundException)
                {
                    continue;
                }

            }
        }
    }
}
