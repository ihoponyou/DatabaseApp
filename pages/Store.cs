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
    public partial class Store : UserControl, IPage
    {
        public string Title { get; }

        public Store()
        {
            Title = "Store";
            InitializeComponent();
        }

        public void RefreshPage()
        {

        }

        private void Store_Load(object sender, EventArgs e)
        {
            
        }
    }
}
