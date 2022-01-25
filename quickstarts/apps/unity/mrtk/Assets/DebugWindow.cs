using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DebugWindow : MonoBehaviour
{
    public TextMeshPro textMesh;

    void Awake()
    {
        Application.logMessageReceived += LogMessage;
    }

    //void OnEnable()
    //{
    //    Application.logMessageReceived += LogMessage;
    //}

    //void OnDisable()
    //{
    //    Application.logMessageReceived -= LogMessage;
    //}

    public void LogMessage(string message, string stackTrace, LogType type)
    {
        textMesh.text += message + "\n";
    }
}
