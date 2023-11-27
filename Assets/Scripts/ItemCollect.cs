using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollect : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Destroy(gameObject,0.5f);

            LevelManager.Instance.LevelClear();
        }

        
    }

}
