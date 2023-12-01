using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    private Collider2D coll;
    private Animator animator;
    private SpriteRenderer spriteRenderer;

    public GameObject deathEffect;
    public int lifes;
    public float jumpForce = 2f;



    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<Collider2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity =(Vector2.up * jumpForce);
            HealthReduce();
            enemyHealthCheck();
        }
        
    }

    public void HealthReduce()
    {
        lifes--;
        animator.Play("Mushroom_Hit");
    }

    public void enemyHealthCheck()
    {
        if(lifes==0)
        {
            deathEffect.SetActive(true);
            spriteRenderer.enabled = false;
            Destroy(gameObject,0.5f);
        }
    }
}
