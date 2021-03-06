using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float runSpeed = 2;
    public float jumpSpeed = 3;
    public bool betterJump  = true;
    public float fallMultiplier = 0.5f;
    public float lowJumpMultiplier = 1f;


Rigidbody2D rb2D;
public SpriteRenderer spriteRenderer;
public Animator animator;


    
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
    }

    void FixedUpdate()
    {
        if(Input.GetKey("d") || Input.GetKey("right")) {
        
            rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);
            spriteRenderer.flipX = false;
            animator.SetBool("Run", true);
        
        }else if(Input.GetKey("a") || Input.GetKey("left")) {
        
            rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
            spriteRenderer.flipX = true;
            animator.SetBool("Run", true);
        
        }else{

            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
            animator.SetBool("Run", false);
        }

        if((Input.GetKey("w") || Input.GetKey("up")) && CheckGround.isGrounded ) {
        
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
        
        }

        if(CheckGround.isGrounded==false) {
            animator.SetBool("Jump", true);
            animator.SetBool("Run", false);
        }
                if(CheckGround.isGrounded==true) {
                    animator.SetBool("Jump", false);

                }

        if(betterJump) {
        
            if(rb2D.velocity.y<0) {
        
                rb2D.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier) * Time.deltaTime;
        
            }
        

            if(rb2D.velocity.y>0 && !(Input.GetKey("w") || Input.GetKey("up"))) {
        
                rb2D.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier) * Time.deltaTime;
        
            }
        }

if(Input.GetKey("e")) {
    if(CheckDoggy.isNear) {
    Debug.Log("Salvando al perrito");
    animator.SetBool("Accion", true);    
    }else{
    Debug.Log("Accion X");    
    
    }
    animator.SetBool("Accion", false);
}

    }
}
