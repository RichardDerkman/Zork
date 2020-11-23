using System.Windows.Forms;
using System;
using Zork.Builder.ViewModels;
using System.ComponentModel;
using System.Collections.Generic;

namespace Zork.Builder
{
    public partial class NeighborControl : UserControl
    {

        public static readonly Room NoNeighbor = new Room("<None>");

        public void UpdatePossibleNeighbors(IEnumerable<Room> allRooms)
        {
            List<Room> rooms = new List<Room>(allRooms);
            rooms.Insert(0, NoNeighbor);

            _possibleRooms = new BindingList<Room>(rooms);

            neighborComboBox.SelectedIndexChanged -= neighborComboBox_SelectedIndexChanged;
            neighborComboBox.DataSource = _possibleRooms;
            neighborComboBox.SelectedIndexChanged += neighborComboBox_SelectedIndexChanged;
        }

        public Directions Direction
        {
            get => _direction;

            set
            {
                _direction = value;
                neighborTextBox.Text = _direction.ToString();
            }
        }

        public Room Room
        {
            get => _room;
            set
            {
                _room = value;
                if (_room != null)
                {
                    _possibleRooms.Remove(_room);

                    if (_room != null && _room.Neighbors.TryGetValue(Direction, out Room neighbor))
                    {
                        neighborComboBox.SelectedItem = neighbor;
                    }
                    else
                    {
                        neighborComboBox.SelectedItem = NoNeighbor;
                    }
                }
            }
        }

        public NeighborControl()
        {
            InitializeComponent();
            Direction = _direction;
        }

        public NeighborControl(Directions direction, Room room)
        {
            Direction = direction;
            Room = room ?? throw new ArgumentNullException(nameof(room));
        }
        private void neighborComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_room != null)
            {
                Room selectedRoom = (Room)neighborComboBox.SelectedItem;
                if (selectedRoom == NoNeighbor)
                {
                    _room.RemoveNeighbor(Direction);
                }
                else
                {
                    _room.AssignNeighbor(Direction, selectedRoom);
                }
            }
        }

        private Directions _direction;
        private Room _room;
        private BindingList<Room> _possibleRooms;
    }
}
