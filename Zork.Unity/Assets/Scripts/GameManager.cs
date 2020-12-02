using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zork;
using Newtonsoft.Json;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private string GameFilename = "Zork";

    [SerializeField]
    private UnityInputService InputService;

    [SerializeField]
    private UnityOutputService OutputService;

    [SerializeField]
    private TextMeshProUGUI Location;

    [SerializeField]
    private TextMeshProUGUI Score;

    [SerializeField]
    private TextMeshProUGUI Moves;

    private void Start()
    {
        TextAsset gameTextAsset = Resources.Load<TextAsset>(GameFilename);
        _game = JsonConvert.DeserializeObject<Game>(gameTextAsset.text);
        _game.Initialize(InputService, OutputService);
        _game.Player.LocationChanged += Player_LocationChanged;
        _game.Player.MovesChanged += (sender, e) => Moves.text = $"Moves: {e}";
        _game.Player.ScoreChanged += (sender, e) => Score.text = $"Score: {e}";

        Location.text = _game.Player.Location.Name;
        InputService.InputField.Select();
        InputService.InputField.ActivateInputField();
    }

    private void Player_LocationChanged(object sender, LocationChangedEventArgs e)
    {
        Location.text = e.NewLocation != null ? e.NewLocation.Name : "Unknown";
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && string.IsNullOrWhiteSpace(InputService.InputField.text) == false)
        {
            OutputService.WriteLine($"> {InputService.InputField.text}");
            InputService.ProcessInput();
            OutputService.WriteLine(string.Empty);
            InputService.InputField.Select();
            InputService.InputField.ActivateInputField();
        }

        if (_game.IsRunning == false)
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;

#else
           Application.Quit();
#endif
        }
    }

    private Game _game;
}
