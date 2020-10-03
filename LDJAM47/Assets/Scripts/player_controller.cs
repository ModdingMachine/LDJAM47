using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{

    public Vector2 motion;
    private Rigidbody2D rb;
    public float speed = 1;
    private BoxCollider2D boxCollider2d;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider2d = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
    }

    private bool IsGrounded() {
        float extraHeight = 0.01f;
        Physics2D.Raycast(boxCollider2d.bounds.center, Vector2.down, boxCollider2d.bounds.extents.y + extraHeight);
    }

    // Update is called once per frame
    void Update()
    {
        if ()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(new Vector2(0, speed * 3), ForceMode2D.Impulse);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (motion.x > -1)
            {
                motion.x =- (Time.deltaTime * speed);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (motion.x < 1) {
                motion.x =+ (Time.deltaTime * speed);
            }
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            motion.x = 0;
        }        
        if (Input.GetKeyUp(KeyCode.D))
        {
            motion.x = 0;
        }

        transform.position = new Vector3(transform.position.x + motion.x, transform.position.y + motion.y, transform.position.z);


    }
}
