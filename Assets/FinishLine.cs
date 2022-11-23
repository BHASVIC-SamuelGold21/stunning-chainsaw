using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
public GameObject enemy; // get enemy components
public Transform finish; // get transform component
void Update() //update is called every frame
{
    if(enemy.transform.position.y <= finish.position.y) //when the enemy position is below finish line on the y axis
	{
        Destroy(enemy); //removes enemy
        //also add checks for time and other stats here at that stage
	}
	
}
}
