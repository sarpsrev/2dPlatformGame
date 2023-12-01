using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUIManager : MonoBehaviour
{
    public GameObject pausePanel;
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
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
