using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform   c;
    public Rigidbody2D p;
    

    void Start()
    {
                
    }

    // Update is called once per frame
    void Update()
    { 
        // if(Math.Abs(p1.transform.position.y - p2.transform.position.y)  <  difference){
        //     if((p1.transform.position.y + p2.transform.position.y)/2 < -1){
        //         c.transform.position = new Vector3 (c.transform.position.x, 0, c.transform.position.z);
        //     }
        //     else{
        //         c.transform.position = new Vector3 (c.transform.position.x, ((p1.transform.position.y + p2.transform.position.y)/2)+1, c.transform.position.z);
        //     }
        // }
        // else{
        //     c.transform.position = new Vector3 (c.transform.position.x, Math.Max(p1.transform.position.y,p2.transform.position.y) + 1 - (difference/2), c.transform.position.z);
        // }
        c.transform.position = new Vector3 (p.transform.position.x, p.transform.position.y, c.transform.position.z);
        
}
}
