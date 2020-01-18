namespace CommentRanking
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenDatabase = new System.Windows.Forms.Button();
            this.ListView = new System.Windows.Forms.ListView();
            this.Rank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HandleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OpenName = new System.Windows.Forms.Button();
            this.database_status = new System.Windows.Forms.Label();
            this.name_status = new System.Windows.Forms.Label();
            this.CommunityId = new System.Windows.Forms.TextBox();
            this.community_name = new System.Windows.Forms.Label();
            this.community_id_status = new System.Windows.Forms.Label();
            this.Reload = new System.Windows.Forms.Button();
            this.ranking_status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpenDatabase
            // 
            this.OpenDatabase.Location = new System.Drawing.Point(12, 12);
            this.OpenDatabase.Name = "OpenDatabase";
            this.OpenDatabase.Size = new System.Drawing.Size(167, 36);
            this.OpenDatabase.TabIndex = 0;
            this.OpenDatabase.Text = "データベースを開く";
            this.OpenDatabase.UseVisualStyleBackColor = true;
            this.OpenDatabase.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // ListView
            // 
            this.ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Rank,
            this.HandleName,
            this.Count});
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(12, 199);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(508, 219);
            this.ListView.TabIndex = 1;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            // 
            // Rank
            // 
            this.Rank.Text = "順位";
            // 
            // HandleName
            // 
            this.HandleName.Text = "お名前";
            this.HandleName.Width = 180;
            // 
            // Count
            // 
            this.Count.Text = "コメント数";
            this.Count.Width = 120;
            // 
            // OpenName
            // 
            this.OpenName.Location = new System.Drawing.Point(12, 54);
            this.OpenName.Name = "OpenName";
            this.OpenName.Size = new System.Drawing.Size(167, 36);
            this.OpenName.TabIndex = 2;
            this.OpenName.Text = "コテハンを開く";
            this.OpenName.UseVisualStyleBackColor = true;
            this.OpenName.Click += new System.EventHandler(this.OpenName_Click);
            // 
            // database_status
            // 
            this.database_status.AutoSize = true;
            this.database_status.Location = new System.Drawing.Point(185, 24);
            this.database_status.Name = "database_status";
            this.database_status.Size = new System.Drawing.Size(301, 12);
            this.database_status.TabIndex = 3;
            this.database_status.Text = "アンコちゃんでエクスポートしたdatabase.ansqliteを開いてください";
            // 
            // name_status
            // 
            this.name_status.AutoSize = true;
            this.name_status.Location = new System.Drawing.Point(185, 66);
            this.name_status.Name = "name_status";
            this.name_status.Size = new System.Drawing.Size(282, 12);
            this.name_status.TabIndex = 4;
            this.name_status.Text = "アンコちゃんでエクスポートしたname.ansqliteを開いてください";
            // 
            // CommunityId
            // 
            this.CommunityId.Location = new System.Drawing.Point(80, 100);
            this.CommunityId.Name = "CommunityId";
            this.CommunityId.Size = new System.Drawing.Size(100, 19);
            this.CommunityId.TabIndex = 5;
            // 
            // community_name
            // 
            this.community_name.AutoSize = true;
            this.community_name.Location = new System.Drawing.Point(10, 103);
            this.community_name.Name = "community_name";
            this.community_name.Size = new System.Drawing.Size(64, 12);
            this.community_name.TabIndex = 6;
            this.community_name.Text = "コミュニティID";
            // 
            // community_id_status
            // 
            this.community_id_status.AutoSize = true;
            this.community_id_status.Location = new System.Drawing.Point(186, 103);
            this.community_id_status.Name = "community_id_status";
            this.community_id_status.Size = new System.Drawing.Size(0, 12);
            this.community_id_status.TabIndex = 7;
            // 
            // Reload
            // 
            this.Reload.Location = new System.Drawing.Point(13, 157);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(167, 36);
            this.Reload.TabIndex = 8;
            this.Reload.Text = "ランキング表示";
            this.Reload.UseVisualStyleBackColor = true;
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // ranking_status
            // 
            this.ranking_status.AutoSize = true;
            this.ranking_status.Location = new System.Drawing.Point(186, 169);
            this.ranking_status.Name = "ranking_status";
            this.ranking_status.Size = new System.Drawing.Size(174, 12);
            this.ranking_status.TabIndex = 9;
            this.ranking_status.Text = "準備ができたらボタンを押してください";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "集計期間";
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(80, 132);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(100, 19);
            this.Year.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "コミュニティIDを入力してください";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "集計したい年を西暦で入力してください";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 430);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ranking_status);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.community_id_status);
            this.Controls.Add(this.community_name);
            this.Controls.Add(this.CommunityId);
            this.Controls.Add(this.name_status);
            this.Controls.Add(this.database_status);
            this.Controls.Add(this.OpenName);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.OpenDatabase);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "CommentRanking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenDatabase;
        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.ColumnHeader Rank;
        private System.Windows.Forms.ColumnHeader Count;
        private System.Windows.Forms.ColumnHeader HandleName;
        private System.Windows.Forms.Button OpenName;
        private System.Windows.Forms.Label database_status;
        private System.Windows.Forms.Label name_status;
        private System.Windows.Forms.TextBox CommunityId;
        private System.Windows.Forms.Label community_name;
        private System.Windows.Forms.Label community_id_status;
        private System.Windows.Forms.Button Reload;
        private System.Windows.Forms.Label ranking_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}