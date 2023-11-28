using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class LevelManager : MonoBehaviour
{
    
    public static LevelManager Instance;

    LevelSelect levelSelect;

    private void Awake() 
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        levelSelect = GetComponent<LevelSelect>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelClear()
    {
        if(transform.childCount==1)
        {
           
           levelSelect.getLevelIndex();
           SceneManager.LoadScene(0);
        }
    }
}
