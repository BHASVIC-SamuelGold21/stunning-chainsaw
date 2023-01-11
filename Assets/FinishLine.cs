using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public Transform finish; // get transform component
    public Material transparentMat; //transparent material for finish
    public float levelTimer = 0; //public runtime for dataManager
    public bool passFinish = false;
    private bool finalTimeRecorded;
    private Renderer ren; //renderer component
    void Start() {
        ren = GetComponent<Renderer>();
        levelTimer = 0.0f;
        passFinish = false;
    }
    void Update() //update is called every frame
    {    
        
        if(!passFinish)
        {
            levelTimer += 1* Time.deltaTime;
        }
        if(transform.position.y <= finish.position.y && !finalTimeRecorded) //when the enemy position is below finish line on the y axis
        {
            ren.material = transparentMat; //changes the material to invisible
            passFinish = true;
            finalTimeRecorded = true;
        }
    }
}
