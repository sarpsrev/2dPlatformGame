using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenuManager : MonoBehaviour
{
    public GameObject settingPanel;
    public AudioSource buttonClickSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void settingMenu()
    {
        settingPanel.SetActive(!settingPanel.activeSelf);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("LevelSelection");
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void buttonClicked()
    {
        buttonClickSound.Play();
    }

    
}
