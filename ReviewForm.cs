using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseApp
{
    public partial class ReviewForm : Form
    {
        private DatabaseManager databaseManager;
        private int userid, gameid;
        public ReviewForm(int gameid, int userid)
        {
            databaseManager = new DatabaseManager();
            this.userid = userid;
            this.gameid = gameid;
            InitializeComponent();

        }

        private void ReviewForm_Load(object sender, EventArgs e)
        { 
            var gameTitle = databaseManager.Query($"SELECT game_title FROM game WHERE game.game_id = '{this.gameid}';");
            gameTitle.Read();
            titleLbl.Text = gameTitle[0].ToString();
        }
        private void postReviewBtn_Click(object sender, EventArgs e)
        {
            PostReview(gameid, userid);
        }
        private void cancelBtn_Click(Object sender, EventArgs e)
        {
            Close();
        }
        private void PostReview(int gameid, int userid)
        {
            if (reviewRichTextBox.Text == "")
                return;
            //not safe from sql injection
            databaseManager.Query(
                $"INSERT INTO review (author_id, game_id, review_text, review_is_positive, post_date) VALUES" +
                $"('{userid}', '{gameid}', '{reviewRichTextBox.Text}', '{likeCheckBox.Checked}','{DateTime.Now}');"
                );

        }
    }
}
