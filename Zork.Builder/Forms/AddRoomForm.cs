using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Zork.Builder.Forms
{
    public partial class AddRoomForm : Form
    {
        public string RoomName
        {
            get => textBoxAddName.Text;
            set => textBoxAddName.Text = value;
        }

        public string RoomDescription
        {
            get => textBoxAddDescription.Text;
            set => textBoxAddDescription.Text = value;
        }

        public AddRoomForm()
        {
            InitializeComponent();
        }

        private void textBoxAddName_TextChanged(object sender, EventArgs e)
        {
            okRoomButton.Enabled = !string.IsNullOrEmpty(RoomName);
        }
    }
}
