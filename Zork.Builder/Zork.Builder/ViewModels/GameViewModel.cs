using System;
using System.ComponentModel;
using System.IO;
using Zork.Common;
using Newtonsoft.Json;

namespace Zork.Builder.ViewModels
{
    public class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Game Game
        {
            set
            {
                _game = value;
                if (_game != null)
                {
                    Rooms = new BindingList<Room>(_game.World.Rooms);
                }
                else
                {                 
                    Rooms = new BindingList<Room>(Array.Empty<Room>());                    
                }
            }
        }

        public BindingList<Room> Rooms { get; set; }

        public string FullPath { get; set; }

        public string Filename => string.IsNullOrWhiteSpace(FullPath) ? "Untitled" : Path.GetFileNameWithoutExtension(FullPath);

        public Room StartingLocation
        {
            get => _game?.World.StartingLocation;
            set
            {
                if (_game != null)
                {
                    _game.World.StartingLocation = value;
                }
            }
        }

        public string WelcomeMessage
        {
            get => _game?.WelcomeMessage;
            set
            {
                if (_game != null)
                {
                    _game.WelcomeMessage = value;
                }
            }
        }

        public string ExitMessage
        {
            get => _game?.ExitMessage;
            set
            {
                if (_game != null)
                {
                    _game.ExitMessage = value;
                }
            }
        }

        public GameViewModel(Game game = null) => Game = game;

        public void SaveGame()
        {
            if (_game != null)
            {
                JsonSerializer serializer = new JsonSerializer
                {
                    Formatting = Formatting.Indented
                };
                using (StreamWriter streamWriter = new StreamWriter(FullPath))
                using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
                {
                    serializer.Serialize(jsonWriter, _game);
                }
            }
        }

        private Game _game;
    }
}