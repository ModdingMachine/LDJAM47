using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rifter : MonoBehaviour
{
    public float health = 100f;
    public string id;
    public float jumpcooldown;
    private Rigidbody2D rb;
    public Vector3 player;
    public GameObject splat;
    public float viewrange = 5;

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "terrain")
        {
            Instantiate(splat, transform.position, transform.rotation);
        }
    }

    private void jump()
    {
       

        rb.AddForce(new Vector3(0, transform.up.y + 5, 0), ForceMode2D.Impulse);

        Quaternion rotation = Quaternion.LookRotation
            (player - transform.position, transform.TransformDirection(Vector3.up));
        transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);

        rb.AddForce(new Vector3(-transform.right.x * 5, 0, 0), ForceMode2D.Impulse);
        jumpcooldown = 3;
    }
    void Update()
    {
        Debug.Log(transform.right.x * 5);
        if (jumpcooldown > 0 && Vector3.Distance(player, transform.position) < 5)
        {
            jumpcooldown -= 1 * Time.deltaTime;
        }
        player = GameObject.FindGameObjectWithTag("Player").transform.position;
        rb = GetComponent<Rigidbody2D>();

        Quaternion rotation = Quaternion.LookRotation
                    (player - transform.position, transform.TransformDirection(Vector3.up));
        transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);

        if (id == "spider")
        {
            if (jumpcooldown <= 0)
            {
                jump();
            }
         }

        if (health <= 0)
        {
            Destroy(gameObject);
        }


        if (id == "walker")
        {
            
        }

    }
}
