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
        
         }
         else if(dice_result == 2){
             Debug.Log("jump increase");
         }
         else if(dice_result == 3){
             Debug.Log("speed decrease");
         }
         else if(dice_result == 4){
             Debug.Log("heavy player");
         }
         else if(dice_result == 5){
             Debug.Log("double jump unlocked");
         }
         else if(dice_result == 6){
             Debug.Log("5 wall jumps increase");
         }     
         else{
            Debug.Log("kuch nahi hua bhai");
         }
         Canvas.SetActive(false);
         rb.constraints = ~RigidbodyConstraints2D.FreezePosition;
    }
}
