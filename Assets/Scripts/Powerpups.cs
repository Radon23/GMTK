using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerpups : MonoBehaviour
{
    public Collider2D cd; 
    public Rigidbody2D rb;
    public GameObject Canvas;
    // Start is called before the first frame update
    void Start()
    {
        // PlayerController player = FindObjectOfType<PlayerController>();
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D cd){
         Canvas.SetActive(true);
         rb.constraints = RigidbodyConstraints2D.FreezePosition;
         }

    public void powerups_decider(){
        
        int dice_result = FindObjectOfType<DiceRoll>().num;
         if(dice_result == 1){
              Debug.Log("SpeedIncreased");
              FindObjectOfType<PlayerController>().maxspeed = 1200;
              FindObjectOfType<PlayerController>().initialspeed = 1000f;
         }
         else if(dice_result == 2){
             Debug.Log("Wall Jump Increase");
             FindObjectOfType<PlayerController>().walljumpcount = 3;
         }
         else if(dice_result == 3){
             Debug.Log("speed decrease");
             FindObjectOfType<PlayerController>().maxspeed = 300;
             FindObjectOfType<PlayerController>().initialspeed = 250f;
         }
         else if(dice_result == 4){
             Debug.Log("wall jump off");
             FindObjectOfType<PlayerController>().walljumpcount = 0;
         }
         else if(dice_result == 5){
             Debug.Log("Longer Jump Unlocked");
             FindObjectOfType<PlayerController>().jumptime = 0.5f;
         }
         else if(dice_result == 6){
             Debug.Log("5 wall jumps increase");
             FindObjectOfType<PlayerController>().jumptime = 0.2f;
         }     
         else{
            Debug.Log("Huh Seems Like you have nothing.");
         }
         Canvas.SetActive(false);
         rb.constraints = ~RigidbodyConstraints2D.FreezePosition;
    }
}
