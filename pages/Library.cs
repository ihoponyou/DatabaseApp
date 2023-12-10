using MagcalasCullen_CSCI366_GroupProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private List<Button> gameButtons = new List<Button>();

        public Library()
        {
            Title = "Library";
            InitializeComponent();
        }

        //private void gameButton_Clicked(object sender, EventArgs e)
        //{

        //}

        //public class GameSelectedEventArgs : EventArgs
        //{
        //    public Game AssociatedGame { get; set; }
        //}

        //protected void OnGameSelected(GameSelectedEventArgs args)
        //{
        //    EventHandler<GameSelectedEventArgs> handler = GameSelected;
        //    if (handler != null)
        //    {
        //        handler(this, args);
        //    }
        //}

        //public event EventHandler<GameSelectedEventArgs> GameSelected;

        //private void library_GameSelected(object sender, GameSelectedEventArgs args)
        //{
        //    gameTitleLabel.Text = args.AssociatedGame.Title;
        //}

        //private void gameButton_Clicked()
        //{

        //}

        private void DisplayGameInfo(Game game)
        {
            titleLabel.Text = game.Title;
            releaseDateLabel.Text = game.ReleaseDate;
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

        public void RefreshPage()
        {
            Main mainForm = Parent as Main;

            // load all the games for "logged in" user
            foreach (var entry in mainForm.CurrentUser.OwnedGames)
            {
                Button gameButton = createGameButton(entry.Value);

                gameButtons.Add(gameButton);
                flowLayoutPanel1.Controls.Add(gameButton);
            }
        }

        private void Library_Load(object sender, EventArgs e)
        {

        }
    }
}
