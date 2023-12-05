using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantEnemy : MonoBehaviour
{
    private float waitTime;
    
    public float waitTimeToAttack = 2f;
    public GameObject bulletPrefab;
    public Transform spawnPoint;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        waitTime = waitTimeToAttack;
    }

    // Update is called once per frame
    void Update()
    {
        if(waitTime <= 0)
        {
            waitTime=waitTimeToAttack;
            animator.Play("Attack");
            Invoke("launchBullet",0.3f);
        }
        else
        {
            waitTime -= Time.deltaTime;
        }
    }

    public void launchBullet()
    {
        Instantiate(bulletPrefab,spawnPoint.position,spawnPoint.rotation);
    }
}
