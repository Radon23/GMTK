using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb ;
    public int maxspeed ;
    public float initialspeed ;

    public int jumpforce = 10 ;
    private bool isGrounded ;
    private bool isNearWallleft;
    private bool isNearWallright;
    public Transform feetPos;
    public Transform rightPos;
    public Transform leftPos;
    public float checkradius;
    public LayerMask groundef;
    public LayerMask wall;
    public int walljumpcount;   
    private int walljumpcounter; 

    private float jumptimeCounter;
    public float jumptime;
    private bool isJumping;

    // Start is called before the first frame update
    void Start()    
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
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

        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkradius, groundef);
        isNearWallleft =  Physics2D.OverlapCircle(leftPos.position, checkradius, wall);
        isNearWallright = Physics2D.OverlapCircle(rightPos.position, checkradius, wall);
        bool isNearGroundleft = Physics2D.OverlapCircle(leftPos.position, checkradius, groundef);
        bool isNearGroundright = Physics2D.OverlapCircle(rightPos.position, checkradius, groundef);


        if (isGrounded == true && Input.GetKeyDown("w")){
                 rb.AddForce((new Vector2(0 , jumpforce)), ForceMode2D.Impulse) ;
                 isJumping = true;
                 jumptimeCounter = jumptime;
        }
        if(Input.GetKey("w") && isJumping == true){
            if(jumptimeCounter > 0){
                // rb.AddForce((new Vector2(0 , jumpforce)), ForceMode2D.Impulse) ;
               rb.AddForce(new Vector2(0 , jumpforce * Time.deltaTime * 200)) ;
               jumptimeCounter -=  Time.deltaTime;
            }
            else{
                isJumping = false;
            }

        }

        if(isGrounded){
            walljumpcounter = walljumpcount;
        }
        if((Input.GetKeyDown("w") && (isGrounded == false && (isNearWallleft == true|| isNearGroundleft == true))) && walljumpcounter!=0){
            //rb.AddForce(new Vector2(jumpforce/8, jumpforce/30f), ForceMode2D.Impulse);
            rb.velocity = new Vector2(5, 25);
            walljumpcounter -= 1;
        }
        if((Input.GetKeyDown("w") && (isGrounded == false && (isNearWallright == true|| isNearGroundleft == true))) && walljumpcounter!=0){
            //rb.AddForce(new Vector2(-jumpforce/8, jumpforce/30f), ForceMode2D.Impulse);
            rb.velocity = new Vector2(-5, 25);
            walljumpcounter -= 1;
        }


        if(Input.GetKeyUp("w")){
            isJumping = false; 
        }
        
    }
}
