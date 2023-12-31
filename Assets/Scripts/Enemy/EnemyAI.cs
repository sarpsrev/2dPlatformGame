using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Animator animator;
    public float enemySpeed = 2f;
    public Transform[] movingSpot;
    public float startWaitingTime = 3f;

    private float stopTime;
    private int i ;
    private Vector2 currentPos;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        stopTime = startWaitingTime;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(CheckWaiting());
        transform.position = Vector2.MoveTowards(transform.position,movingSpot[i].transform.position,enemySpeed*Time.deltaTime);

        if(Vector2.Distance(transform.position,movingSpot[i].transform.position)<0.1f)
        {
            if(stopTime<=0)
            {
                if (movingSpot[i] != movingSpot[movingSpot.Length-1])
                {
                    i++;
                }
                else
                {
                    i=0;
                }
                stopTime = startWaitingTime;
            }
            else
            {
                stopTime -= Time.deltaTime;
            }
        }
    }
    IEnumerator CheckWaiting()
    {
        currentPos = transform.position;

        yield return new WaitForSeconds(0.5f);

        if(transform.position.x>currentPos.x)
        {
            spriteRenderer.flipX = true;
            animator.SetBool("Idle",false);
        }
        else if(transform.position.x<currentPos.x)
        {
            spriteRenderer.flipX = false;
            animator.SetBool("Idle",false);
        }
        else if (transform.position.x==currentPos.x)
        {
            animator.SetBool("Idle",true);
        }

    }
}
