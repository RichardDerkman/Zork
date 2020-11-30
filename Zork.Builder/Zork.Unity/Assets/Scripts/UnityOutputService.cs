using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zork;
using TMPro;

public class UnityOutputService : MonoBehaviour, IOutputService
{
    [SerializeField]
    private Transform OutputTextContainer;

    [SerializeField]
    private TextMeshProUGUI TextLinePrefab;

    public void Write(string value)
    {
        
    }

    public void Write(object value)
    {
        
    }

    public void WriteLine(string value)
    {
        var textLine = Instantiate(TextLinePrefab, OutputTextContainer);
        textLine.text = value;
    }

    public void WriteLine(object value)
    {
        
    }
}
