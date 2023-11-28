using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getLevelIndex()
    {
        int currentLevelIndex = SceneManager.GetActiveScene().buildIndex;

        if (currentLevelIndex>= PlayerPrefs.GetInt("CurrentLevel"))
        {
            PlayerPrefs.SetInt("CurrentLevel",currentLevelIndex+1);
            
        }
    }
}
