using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public Transform finish; // get transform component
    public Material transparentMat; //transparent material for finish
    public float levelTimer = 0; //public runtime for dataManager
    private bool updateTimer = false;
    public bool passFinish = false;
    private bool finalTimeRecorded;
    private Renderer ren; //renderer componentA
    private int i = 1;
    void Start() {
        ren = GetComponent<Renderer>();
        updateTimer = true;
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
            passFinish = true;
            finalTimeRecorded = true;
        }
    }
    private void OnTriggerEnter(Collider other) {
        ren.material = transparentMat; //changes the material to invisible
    }
}
