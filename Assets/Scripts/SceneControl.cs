using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Analytics;

public class SceneControl : MonoBehaviour
{
    int level = 0;
    float version = 0.1f;
    
    void Start()
    {
        RegisterOfStart();
    }

    
    void Update()
    {
        
    }

    public void NextLevel()
    {
        level++;
    }
    
    public void RegisterOfStart()
    {
        Debug.Log("Registrar inicio level");

        Analytics.CustomEvent("gameStart", new Dictionary<string, object>
        {

        });
    }
    
    public void RegisterOfEnd()
    {
        Debug.Log("Registrar fin level");
        float secsJuego = Time.time;

        Analytics.CustomEvent("gameOver", new Dictionary<string, object>
        {
            {"Time", secsJuego },
            {"Version", version }
        });
    }
}
