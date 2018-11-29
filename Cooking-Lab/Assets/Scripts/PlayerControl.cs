using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    public float speed = 5;

    private bool facingRight = true;
    private Rigidbody2D rb;
    private bool grounded;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        //MOVEMENT
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
            if (!facingRight)
            {
                facingRight = true;
                transform.Rotate(0f, 180f, 0f);
            }  
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
            if (facingRight)
            {
                facingRight = false;
                transform.Rotate(0f, 180f, 0f);
            }
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
        //JUMPING
        if (Input.GetKeyDown(KeyCode.W) && grounded == true)
        {
            rb.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = false;
        }
    }
}
