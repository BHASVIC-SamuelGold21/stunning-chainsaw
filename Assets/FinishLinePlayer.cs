using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLinePlayer : MonoBehaviour
{
public GameObject player; // get enemy components
public Transform finish; // get transform component
private bool checkFinish = false; //bool stop the update function always looking for position
void Start() {
    checkFinish = true;
}
void Update() //update is called every frame
{
    while(checkFinish == true){
        if(player.transform.position.y <= finish.position.y) //when the enemy position is below finish line on the y axis
        {
            Destroy(player); //removes enemy
            checkFinish = true; //exits the loop
            //also add checks for time and other stats here at that stage
        }
    }
}
}
