using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLinePlayer : MonoBehaviour
{
public GameObject player; // get enemy components
public Transform finish; // get transform component
void Start() {

}
void Update() //update is called every frame
{
    if(player.transform.position.y <= finish.position.y) //when the enemy position is below finish line on the y axis
     {
        Destroy(player); //removes player
        //also add checks for time and other stats here at that stage
        
    } 
}
}
