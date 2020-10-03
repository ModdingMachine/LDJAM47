using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ductgun : MonoBehaviour
{

    public GameObject tape;
    public ParticleSystem fireparticle;
    public Transform firetip;
    public float thrust = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouseScreenPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mouseScreenPosition - (Vector2)transform.position).normalized;
        transform.up = direction;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(fireparticle, firetip.position, transform.rotation);
            GameObject rb = Instantiate(tape, firetip.position, transform.rotation);
            rb.GetComponent<Rigidbody2D>().AddForce(transform.up * thrust, ForceMode2D.Impulse);

            //recoil:

        }


    }
}
