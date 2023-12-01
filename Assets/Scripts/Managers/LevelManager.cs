using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
 
public class LevelManager : MonoBehaviour
{
    
    public static LevelManager Instance;

    LevelSelect levelSelect;

    public Text fruitCounterText;

    private void Awake() 
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        levelSelect = GetComponent<LevelSelect>();
        fruitCounterText.text = transform.childCount.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        fruitCounterText.text = transform.childCount.ToString();
    }

    public void LevelClear()
    {
        if(transform.childCount==1)
        {
           
           levelSelect.getLevelIndex();
           SceneManager.LoadScene("LevelSelection");
        }
    }
}
