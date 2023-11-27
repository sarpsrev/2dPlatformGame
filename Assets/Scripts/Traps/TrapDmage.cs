using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapDmage : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
        
    }

}
