using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    

    public Rigidbody2D rb ;
    public int maxspeed = 7 ;
    public float initialspeed = 5f ;

    // Start is called before the first frame update
    void Start()
    {
        // offtimecounter = offtime;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
       
    }

    void Update(){

         if ( Input.GetKey("d") ) 
        {
            if ( rb.velocity.x < maxspeed ) 
            {
                rb.AddForce(new Vector2(initialspeed * Time.deltaTime , 0)) ;
                
            }
        }
        if ( Input.GetKey("a")) 
        {
            if ( rb.velocity.x > -maxspeed ) 
            {
                rb.AddForce(new Vector2(-initialspeed * Time.deltaTime , 0)) ;
               
            }
        }

        if ( Input.GetKeyUp("d") || Input.GetKeyUp("a"))
        {
               rb.velocity = new Vector2(0,rb.velocity.y);
               
        }

    }

    
}
