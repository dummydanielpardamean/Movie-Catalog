using Movie_Catalog.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Catalog
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // Set Watching list user control sebagai default user control.
            ChangeToUserControlWatchingList();
        }

        private void WatchingListButton_Click(object sender, EventArgs e)
        {
            // Set Container ke user control watching list.
            ChangeToUserControlWatchingList();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            // Set Container ke user control browse.
            ChangeToUserControlBrowse();
        }

        private void ChangeToUserControlWatchingList()
        {
            panelContainer.Controls.Clear();

            if (!panelContainer.Controls.Contains(ucWatchingList.Instance))
            {
                panelContainer.Controls.Add(new ucWatchingList());
                ucWatchingList.Instance.Dock = DockStyle.Fill;
                ucWatchingList.Instance.BringToFront();
            }
            else
            {
                ucWatchingList.Instance.BringToFront();
            }
        }

        private void ChangeToUserControlBrowse()
        {
            panelContainer.Controls.Clear();

            if (!panelContainer.Controls.Contains(ucBrowse.Instance))
            {
                panelContainer.Controls.Add(ucBrowse.Instance);
                ucBrowse.Instance.Dock = DockStyle.Fill;
                ucBrowse.Instance.BringToFront();
            }
            else
            {
                ucBrowse.Instance.BringToFront();
            }
        }

        // Event Handler untuk button AddMovie
        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            // Munculkan Form AddMovie
            AddMovie addMovie = new AddMovie();
            addMovie.ShowDialog();
        }
    }
}
