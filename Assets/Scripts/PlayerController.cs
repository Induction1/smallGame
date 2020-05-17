using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float jumpForce = 2.0f;
    private float moveInput;
    private Rigidbody2D rb;
    public bool isGrounded = true;

    private float jumpTimeCounter;
    public float jumpTime;
    public float tick = 0f;

    public Vector2 jump;

    private bool facingRight = true;

    private Animator anim;

    public float boundary;
    public float bound;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        jump = new Vector2(0, 3.0f);

    }

    private void OnCollisionEnter2D(Collision2D collision) {
        isGrounded = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (facingRight == false && moveInput > 0)
        {
            flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            flip();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && tick<2){
        
            rb.velocity = Vector2.up * jumpForce;
            jumpTimeCounter = jumpTime;
            tick += 1;
            isGrounded = false;


            anim.SetTrigger("takeOff");
        }


        if (isGrounded == true){
            tick = 0;
            anim.SetBool("isJumping", false);
        }

        else{
            anim.SetBool("isJumping", true);
        }

        if (moveInput == 0){
            anim.SetBool("isRunning", false);
        }
        else{
            anim.SetBool("isRunning", true);
        }

        if(transform.position.x < -1 * boundary)
		{
            transform.position = new Vector2(-1 * boundary, transform.position.y);
		}

        if (transform.position.x > bound)
        {
            transform.position = new Vector2(bound, transform.position.y);
        }
    }

    void flip()
    {

        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
        
    }
}
