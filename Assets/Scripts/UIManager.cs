using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject optionsPanel;

    public void OptionsPanel()
    {
        //Paramos el tiempo en Unity
        Time.timeScale = 0;
        optionsPanel.SetActive(true);
    }
    
    public void Return()
    {
        //Paramos el tiempo en Unity
        Time.timeScale = 1;
        optionsPanel.SetActive(false);
    }

    public void AnotherOptins()
    {
        //Sound
        //Graphic
    }

    public void QuitGame()
    {
        //Solo funciona cuando se realiza el ejecutable en pc
        Application.Quit();
    }
}
