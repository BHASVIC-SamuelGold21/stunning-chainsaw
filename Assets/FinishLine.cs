using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
public GameObject enemy; // get enemy components
public Transform finish; // get transform component
public Material transparentMat;
private Renderer ren;
void Start() {
    ren = GetComponent<Renderer>();
}
void Update() //update is called every frame
{ 
    if(enemy.transform.position.y <= finish.position.y) //when the enemy position is below finish line on the y axis
    {
        ren.material = transparentMat; //changes the material to invisible
        //also add checks for time and other stats here at that stage

    }
}
}
