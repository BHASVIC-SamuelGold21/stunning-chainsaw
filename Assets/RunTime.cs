using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunTime : MonoBehaviour
{
float timerInSecond = 0.0f;
private float levelTimer = 0.0f;
private bool updateTimer = false;
    //Start is called before the first frame update
    void Start()
    {
        updateTimer = true; //set values for when script becomes non-static
        levelTimer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(updateTimer == true){ //while true the timer will count up
            levelTimer += 1* Time.deltaTime; 
        }
    }
}
