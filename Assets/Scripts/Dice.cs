   using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Dice : MonoBehaviour
{
    // Start is called before the first frame update
    public void roll()
    { 
        System.Random rnd = new System.Random();
        int x = rnd.Next(1,7);
        Debug.Log(x);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
