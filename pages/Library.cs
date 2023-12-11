using MagcalasCullen_CSCI366_GroupProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseApp.pages
{
    public partial class Library : UserControl, IPage
    {
        public string Title { get; }
        // int is the associated game's id
        private Dictionary<int, Button> gameButtons = new Dictionary<int, Button>();

        public Library()
        {
            Title = "Library";
            InitializeComponent();
        }

        private void DisplayGameInfo(Game game)
        {
            titleLabel.Show();
            tagLabel.Show();
            releaseDateLabel.Show();
            publisherLabel.Show();
            descriptionLabel.Show();

            titleLabel.Text = game.Title;

            string tagText = "";
            foreach (Tag tag in game.Tags.Values)
            {
                bool last = tag.Equals(game.Tags.Values.Last());
                tagText += tag.Name + ((last) ? "" : ", ");
            }
            tagLabel.Text = tagText;

            releaseDateLabel.Text = $"RELEASED: {game.ReleaseDate}";
            publisherLabel.Text = $"PUBLISHER: {game.Publisher.Name}";

            descriptionLabel.Text = game.Description;
        }

        private Button createGameButton(Game game)
        {
            var gameButton = new Button();

            gameButton.Text = game.Title;
            gameButton.Width = 195;
            gameButton.BackColor = SystemColors.Window;

            gameButton.Click += (sender, e) => DisplayGameInfo(game);

            return gameButton;
        }

        private struct TagItem
        {
            public int ID { get; set; }
            public string Name { get; set; }

            public TagItem(int tagID, string tagName)
            {
                ID = tagID;
                Name = tagName;
            }
        }

        public void RefreshPage()
        {
            Main mainForm = Parent as Main;

            // reset game details
            titleLabel.Text = $"Welcome, {mainForm.CurrentUser.Username}";
            tagLabel.Text = "Choose a game to see its details";
            releaseDateLabel.Hide();
            publisherLabel.Hide();
            descriptionLabel.Hide();

            // clear current game list
            gameListLayout.Controls.Clear();

            // load all the games for "logged in" user
            gameButtons.Clear();

            tagCombo.Items.Clear();
            tagCombo.Items.Add(new TagItem(-1, "All"));
            tagCombo.SelectedItem = tagCombo.Items[0];

            foreach (var entry in mainForm.CurrentUser.OwnedGames)
            {
                // add button to game list
                Button gameButton = createGameButton(entry.Value);

                gameButtons.Add(entry.Key, gameButton);
                gameListLayout.Controls.Add(gameButton);

                // add tags to dropdown if they are not in
                foreach (var kvPair in entry.Value.Tags)
                {
                    TagItem tagItem = new TagItem(kvPair.Value.ID, kvPair.Value.Name);

                    if (!tagCombo.Items.Contains(tagItem))
                    {
                        tagCombo.Items.Add(tagItem);
                    }
                }
            }
        }

        private void Library_Load(object sender, EventArgs e)
        {

        }

        private void tagCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Main mainForm = Parent as Main;

            TagItem selectedTag = (TagItem) tagCombo.SelectedItem;
            Debug.WriteLine(selectedTag.ID);

            foreach(KeyValuePair<int, Button> keyValuePair in gameButtons)
            {
                // if all is selected
                if (selectedTag.ID == -1)
                {
                    keyValuePair.Value.Show();
                    continue;
                }

                // check if associated game has the selected tag
                string query = $"SELECT * FROM taggedas WHERE game_id = {keyValuePair.Key} AND tag_id = {selectedTag.ID}";
                var results = mainForm.dbm.Query(query);

                if (results.HasRows)
                    keyValuePair.Value.Show();
                else
                    keyValuePair.Value.Hide();

                results.Close();
            }
        }
    }
}
