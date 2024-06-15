using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpforce;
    public Transform feet;
    public LayerMask ground;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetBool("isjumping", false);
    }
    public void JumpForce()
    {
        
        if (IsGrounded())
        {
            
            Vector2 movement = new Vector2(rb.velocity.x, jumpforce);
            rb.velocity = movement;
            animator.SetBool("isjumping", true);
            
        }
       
      

        
    }
    
    public bool IsGrounded()
    {
        Collider2D ground_Check = Physics2D.OverlapCircle(feet.position, 0.6f, ground);
         if (ground_Check  != null)
        {
            return true;
           
        }
         else
        {
            return false;
           
        }
    }
   
}

