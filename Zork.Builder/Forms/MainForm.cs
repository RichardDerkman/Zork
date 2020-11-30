using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Zork.Common;
using Zork.Builder.ViewModels;
using Zork.Builder.Forms;
using System.Linq;
using System.Collections.Generic;

namespace Zork.Builder
{
    public partial class MainForm : Form
    {

        private Game Game { get; set; }

        public MainForm()
        {
            InitializeComponent();
            gameViewModelBindingSource.DataSource = _viewModel;

            _neighborControls.AddRange(new NeighborControl[] { northNeighborControl, eastNeighborControl, southNeighborControl, westNeighborControl });

            CreateGame();
        }

        #region File Menu Event Handlers
        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateGame();
        }

        private void CreateGame()
        {

            _viewModel.FullPath = null;
            Game = new Game(new World(), null);
        }

        private void OpenGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _viewModel.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
                _viewModel.FullPath = openFileDialog.FileName;
                roomsBindingSource.DataSource = _viewModel.Rooms;
                startingLocationBindingSource.DataSource = _viewModel.Rooms;

                foreach (var neighborControl in _neighborControls)
                {
                    neighborControl.UpdatePossibleNeighbors(_viewModel.Rooms);
                }
            }
        }

        private void SaveWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_viewModel.FullPath))
            {
                saveWorldToolStripMenuItem.PerformClick();
            }
            else
            {
                _viewModel.SaveGame();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _viewModel.FullPath = saveFileDialog.FileName;
                _viewModel.SaveGame();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutForm aboutForm = new AboutForm())
            {                
                aboutForm.ShowDialog();
            }
        }


        private readonly GameViewModel _viewModel = new GameViewModel();

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            using (AddRoomForm addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    bool foundExistingRoom = false;

                    foreach (Room room in _viewModel.Rooms)
                    {
                        if (room.Name.Equals(addRoomForm.RoomName, StringComparison.InvariantCultureIgnoreCase))
                        {
                            foundExistingRoom = true;
                        }
                    }

                    if (foundExistingRoom == false)
                    {
                        Room room = new Room { Name = addRoomForm.RoomName, Description = addRoomForm.RoomDescription };
                        _viewModel.Rooms.Add(room);
                    }
                    else
                    {
                        MessageBox.Show($"Room: {addRoomForm.RoomName} already exists.");
                    }
                }                
            }
        }

        private void deleteRoomButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this Room?", "Zork Builder", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _viewModel.Rooms.Remove((Room)roomsListBox.SelectedItem);
                roomsListBox.SelectedItem = _viewModel.Rooms.FirstOrDefault();
            }
        }

        private void roomsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var neighborControl in _neighborControls)
            {
                neighborControl.UpdatePossibleNeighbors(_viewModel.Rooms);
            }

            foreach (var neighborControl in _neighborControls)
            {
                neighborControl.Room = (Room)roomsListBox.SelectedItem;
            }
        }

        private readonly List<NeighborControl> _neighborControls = new List<NeighborControl>();
    }
}
