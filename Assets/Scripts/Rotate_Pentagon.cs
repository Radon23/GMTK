using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Pentagon : MonoBehaviour
{
    public Rigidbody2D rb;
    public Rigidbody2D player;
    public GameObject anchor;
    float rotationAmount = .1f;
    float delaySpeed = 0.0013f;

    public IEnumerator SlowSpin(){
        float count = 0;
        while(count <= 72){
            rb.transform.RotateAround(anchor.transform.localPosition, Vector3.forward, rotationAmount);
            player.transform.RotateAround(anchor.transform.localPosition, Vector3.forward, rotationAmount);
            player.gravityScale = 0;
            player.velocity = new Vector2(0,0);
            count += rotationAmount;
            yield return new WaitForSeconds(delaySpeed);
    }
    
            player.AddForce((new Vector2(20 , 20)), ForceMode2D.Impulse) ;
            Debug.Log("hello");
            player.gravityScale = 5;
            player.rotation = 0;
            
            
    }

    public IEnumerator SlowSpinRev(){
        float count = 0;
        while(count <= 72){
            rb.transform.RotateAround(anchor.transform.localPosition, Vector3.forward, -rotationAmount);
            player.transform.RotateAround(anchor.transform.localPosition, Vector3.forward, -rotationAmount);
            player.gravityScale = 0;
            player.velocity = new Vector2(0,0);
            count += rotationAmount;
            yield return new WaitForSeconds(delaySpeed);
    }
    
            player.AddForce((new Vector2(-20 , 20)), ForceMode2D.Impulse) ;
            Debug.Log("hello");
            player.gravityScale = 5;
            player.rotation = 0;
            
            
    }

    
    
}
