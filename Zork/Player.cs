using Newtonsoft.Json;
using System.Collections.Generic;
namespace Zork
{
    
    public class Player
    {
        public World World { get; }
      
        [JsonIgnore]
        public Room Location { get; private set; }

        public bool Move (Directions directions)
        {
            bool isValidMove = Location.Neighbors.TryGetValue(directions, out Room destination);
            if (isValidMove)
            {
                Location = destination;
            }
            return isValidMove;
        }
       

        [JsonIgnore]
        public string LocationName
        {
            get
            {
                return Location?.Name;
            }
            set
            {
                Location = World?.RoomsByName.GetValueOrDefault(value);
            }
        }
        public Player(World world, string startingLocation)
        {
            World = world;
            LocationName = startingLocation;
        }
        
    }
}
