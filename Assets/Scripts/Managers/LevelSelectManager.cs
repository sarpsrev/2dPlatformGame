using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelSelectManager : MonoBehaviour
{
    public Button[] buttons;


    int levelIndex;

    void Start()
    {
        levelIndex = PlayerPrefs.GetInt("CurrentLevel",1);

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable=false;
        }
        for (int i = 0; i <levelIndex; i++)
        {
            buttons[i].interactable=true;
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
}
