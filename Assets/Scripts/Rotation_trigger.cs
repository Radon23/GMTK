using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_trigger : MonoBehaviour
{
    public Collider2D cd;
    public Rigidbody2D rb;
    public Collider2D itself;
    float time = 0 ;
    
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
        // itself.enabled = false;
        // if(time<10){
            
        //     time+=Time.deltaTime;
        // }
        // else{
        //     itself.enabled = true;
        // }
        
        FindObjectOfType<PlayerController>().maxspeed = 600;
        FindObjectOfType<PlayerController>().initialspeed = 500f;
        FindObjectOfType<PlayerController>().walljumpcount = 1 ;
        FindObjectOfType<PlayerController>().jumptime = 0.3f;
    }
}
