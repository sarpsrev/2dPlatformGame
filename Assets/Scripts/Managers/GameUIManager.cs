using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameUIManager : MonoBehaviour
{
    public GameObject pausePanel;
    public AudioSource clickSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pausePanelController()
    {
        clickSound.Play();
        pausePanel.SetActive(!pausePanel.activeSelf);

        if (pausePanel.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }

    }

    public void resumeGame()
    {
        Time.timeScale=1f;
        pausePanel.SetActive(false);
        clickSound.Play();
    }

    public void mainMenu()
    {
        clickSound.Play();
        SceneManager.LoadScene("MainMenu");
    }
}
