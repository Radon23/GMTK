using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_trigger : MonoBehaviour
{
    public Collider2D cd;
    public Rigidbody2D rb;
    
       // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D cd)
    {
        if (rb.velocity.x > 0) {
            StartCoroutine(FindObjectOfType<Rotate_Pentagon>().SlowSpin());
        // FindObjectOfType<PlayerController>().transform.position = new Vector2(-2466, (float)1057.9);

        Debug.Log("hello");
        }

        else if (rb.velocity.x < 0) {
            StartCoroutine(FindObjectOfType<Rotate_Pentagon>().SlowSpinRev());
        // FindObjectOfType<PlayerController>().transform.position = new Vector2(-2466, (float)1057.9);

        Debug.Log("hello");
        }

    }
}
