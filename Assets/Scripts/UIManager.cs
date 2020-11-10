using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.Analytics;

public class UIManager : MonoBehaviour
{
    public GameObject optionsPanel;
    public AudioSource clip;
    public bool isMuted = false;
    SceneControl ctrScene;

    private void Start()
    {
        ctrScene = GetComponent<SceneControl>();
    }

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
        isMuted = !isMuted;
        AudioListener.pause = isMuted;
        //Graphic
    }

    public void QuitGame()
    {
        //Solo funciona cuando se realiza el ejecutable en pc
        Application.Quit();
        Debug.Log("Finish");
        ctrScene.RegisterOfEnd();
    }

    public void PlaySoundButton()
    {
        clip.Play();
    }
}
