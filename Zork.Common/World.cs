using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Zork.Common;

namespace Zork
{
    public class World : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<Room> Rooms { get; set; } = new List<Room>();

        [JsonIgnore]
        public IReadOnlyDictionary<string, Room> RoomsByName => mRoomsByName;

        public Player SpawnPlayer() => new Player(this, StartingLocationName);

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            mRoomsByName = Rooms.ToDictionary(room => room.Name, room => room);

            foreach (Room room in Rooms)
            {
                room.UpdateNeighbors(this);
            }

            //StartingLocation = RoomsByName[StartingLocationName];
        }

        [JsonIgnore]
        public Room StartingLocation
        {
            get => _startingLocation;
            set
            {
                _startingLocation = value;
                StartingLocationName = _startingLocation?.Name;
            }
        }

        [JsonProperty(PropertyName = "StartingLocation")]
        private string StartingLocationName { get; set; }

        private Dictionary<string, Room> mRoomsByName = new Dictionary<string, Room>();
        private Room _startingLocation;
    }
}