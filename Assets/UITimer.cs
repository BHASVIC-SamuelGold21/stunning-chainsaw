using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UITimer : MonoBehaviour
{
    public TMP_Text playerTimer; //edits text show on screen
    public float runTime; //timer
    private string strngRunTime; //time as a string

    private bool finish; //bool for FinishLine passFinish
    // Start is called before the first frame update
    void Start()
    {
        finish = false; //set value
    }
    

    // Update is called once per frame
    void Update()
    {
        var FinishLine = GameObject.Find("Player").GetComponent<FinishLine>(); //getting the component so i can call the level timer
        finish = FinishLine.passFinish; //sets finish to passFinish
        runTime = FinishLine.levelTimer; //run time equal to the levelTimer
        strngRunTime = runTime.ToString(); //convert to string
        if(finish == false){ // only runs whilst finish line isnt crossed
            playerTimer.text = strngRunTime; //display as text
        }

    }
}