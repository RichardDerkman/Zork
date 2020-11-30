using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Zork;

public class UnityInputService : MonoBehaviour, IInputService
{
    public TMP_InputField InputField;

    public event EventHandler<string> InputRecieved;

    public void ProcessInput()
    {
        Assert.IsNotNull(InputField);
        Assert.IsFalse(string.IsNullOrEmpty(InputField.text));
        InputRecieved?.Invoke(this, InputField.text);
    }
}
