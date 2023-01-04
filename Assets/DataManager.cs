using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DataManager : MonoBehaviour
{
    private bool finish;
    private float runTime;
    private float finalTime;
    
    private int i;
    void Start()
    {
        finish = false;
        i = 1;
    }

    // Update is called once per frame
    void Update()
    {
        var FinishLine = GameObject.Find("Enemy (1)").GetComponent<FinishLine>();
        finish = FinishLine.passFinish; //sets finish to passFinish
        runTime = FinishLine.levelTimer; //run time equal to the levelTimer
        if(finish == true){ // only runs whilst finish line isnt crossed
            while(i > 0){ //while loop ensures value is only taken once 
                finalTime = runTime; //final time will be that finish value
                i--; //ends loop
            }
        }

    } 
}

