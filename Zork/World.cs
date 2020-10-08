﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;



namespace Zork
{
   public class World
    {
       
        public Room[] Rooms { get; set; }
        [JsonIgnore]
        public IReadOnlyDictionary<string, Room> RoomsByName => mRoomsByName;

        public Player spawnPlayer() => new Player(this, StartingLocation);

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            mRoomsByName = Rooms.ToDictionary(room => room.Name, room => room);

            foreach(Room room in Rooms)
            {
                room.UpdateNeighbors(this);
            }
        }
        [JsonProperty]
        private string StartingLocation { get; set; }
        private Dictionary<string, Room> mRoomsByName;
        
    }
}
