using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tape : MonoBehaviour
{
    public GameObject tapefloor;
    // Start is called before the first frame update
    public float angle;
    public float damage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        {
            if (collision.gameObject.tag == "hostile")
            {
                rifter rifter = collision.GetComponent<rifter>();
                rifter.health -= damage;
            }
                if (collision.gameObject.tag == "terrain")
            {
                
                angle = transform.rotation.z;
                angle = angle * 100f;
               /* if (Mathf.Abs(angle) >= 0 && Mathf.Abs(angle) <= 45)
                    angle = 0f;
                if (Mathf.Abs(angle) > 45 && Mathf.Abs(angle) <= 90)
                    angle = 90f;
                if (Mathf.Abs(angle) > 90 && Mathf.Abs(angle) <= 120)
                    angle = 90f;
                if (Mathf.Abs(angle) > 120 && Mathf.Abs(angle) <= 180)
                    angle = 180f;
                if (Mathf.Abs(angle) > 180 && Mathf.Abs(angle) <= 230)
                    angle = 180f;
                if (Mathf.Abs(angle) > 230 && Mathf.Abs(angle) <= 270)
                    angle = 270f;
                if (Mathf.Abs(angle) > 270 && Mathf.Abs(angle) <= 330)
                    angle = 270f;
                if (Mathf.Abs(angle) > 330 && Mathf.Abs(angle) <= 360)
                    angle = 360;*/
                Instantiate(tapefloor, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }
    }

}
