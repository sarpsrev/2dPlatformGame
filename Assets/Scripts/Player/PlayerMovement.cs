using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    private float InputDirection;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    private bool canDoubleJump;

    [SerializeField] private float playerMoveSpeed;
    [SerializeField] private float jumpPower;

    public float doubleJumpPower =2f;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }

    void FixedUpdate()
    {
        Movement();

        if(!GroundCheck.isGrounded)
        {
            animator.SetBool("Jump",true);
            animator.SetBool("Run",false);
        }
        
        if(GroundCheck.isGrounded)
        {
            animator.SetBool("Jump",false);
            animator.SetBool("DoubleJump",false);
            animator.SetBool("Fall",false);
        }

        if (rb.velocity.y<0)
        {
            animator.SetBool("Fall",true);
        }
        else if (rb.velocity.y>0)
        {
            animator.SetBool("Fall",false);
        }
    }

    private void CheckInput()
    {
       InputDirection = Input.GetAxisRaw("Horizontal");

       if(InputDirection > 0)
       {
           spriteRenderer.flipX = false;
       }
       else if(InputDirection < 0)
       {
            spriteRenderer.flipX = true;
       }

       if(Input.GetButtonDown("Jump"))
       {
            if (GroundCheck.isGrounded)
            {
                rb.velocity = new Vector2(rb.velocity.x,jumpPower);
                canDoubleJump=true;
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                if (canDoubleJump)
                {
                    canDoubleJump=false;
                    rb.velocity = new Vector2(rb.velocity.x,doubleJumpPower);
                    animator.SetBool("DoubleJump",true);
                }
                
            }
            
       }
    }

    private void Movement()
    {
        rb.velocity = new Vector2(playerMoveSpeed*InputDirection,rb.velocity.y);
        if(rb.velocity.x != 0)
        {
            animator.SetBool("Run",true);
        }
        else
        {
            animator.SetBool("Run",false);
        }
    }
    
}
