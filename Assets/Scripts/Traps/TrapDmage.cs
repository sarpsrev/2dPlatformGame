using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDmage : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.CompareTag("Player"))
        {
            Debug.Log("here");
        }
        
    }

}
