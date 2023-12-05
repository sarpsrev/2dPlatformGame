using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float bulletSpeed = 2f;
    public float bulletLifetime = 3f;

    public bool leftSide;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,bulletLifetime);
    }

    // Update is called once per frame
    void Update()
    {
        if(leftSide)
        {
            transform.Translate(Vector2.left * bulletSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.right * bulletSpeed * Time.deltaTime);
        }
        
    }
}
