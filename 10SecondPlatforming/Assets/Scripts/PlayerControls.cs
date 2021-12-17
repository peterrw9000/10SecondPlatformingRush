using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControls : MonoBehaviour
{
    [SerializeField]
    float speed = 1;
    [SerializeField]
    float jump = 1;

    private bool grounded;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float m = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(m * speed, rb.velocity.y);
        if (Input.GetButtonDown("Jump"))
        {
            if (grounded)
            {
                Jump();
            }
        }
    }

    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jump);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = false;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
