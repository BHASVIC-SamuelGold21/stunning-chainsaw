using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
public Transform finish; // get transform component
public Material transparentMat; //transparent material for finish
public float levelTimer = 0.0f; //public runtime for dataManager
private bool updateTimer = false;
private Renderer ren; //renderer component
void Start() {
    ren = GetComponent<Renderer>();
    updateTimer = true;
    levelTimer = 0.0f;
}
void Update() //update is called every frame
{ 
    if(updateTimer == true)
    {
        levelTimer += 1* Time.deltaTime;
        Debug.Log(levelTimer);
    }
    if(transform.position.y <= finish.position.y) //when the enemy position is below finish line on the y axis
    {
        ren.material = transparentMat; //changes the material to invisible
        updateTimer = false;
    }
}
}
