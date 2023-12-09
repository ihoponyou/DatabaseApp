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

        public void RefreshPage()
        {

        }

        private void Library_Load(object sender, EventArgs e)
        {
            // load all the games for "logged in" user
            for (int i = 0; i < gameButtons.Count; i++)
            {
                var gameButton = new Button();
                gameButtons.Add(gameButton);
                flowLayoutPanel1.Controls.Add(gameButton);
            }
        }
    }
}
