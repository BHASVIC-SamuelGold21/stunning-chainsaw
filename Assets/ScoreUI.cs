using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public TMP_Text scoreOutput; //edits text show on screen
    private string output;
    void Start()
    {

    }
    

    // Update is called once per frame
    void Update()
    {
        int i = 0;
        var dataManager = GameObject.Find("Data Manager").GetComponent<DataManager>(); //getting the component so i can call the level timer
        output = "1) " + dataManager.enemyOrder[0] + "-" + dataManager.finalTime[0] + "\n2) " + dataManager.enemyOrder[1] + "-" + dataManager.finalTime[1] + "\n3) " + dataManager.enemyOrder[2] + "-" + dataManager.finalTime[2] + "\n4) " + dataManager.enemyOrder[3] + "-" + dataManager.finalTime[3] + "\n5) " + dataManager.enemyOrder[4] + "-" + dataManager.finalTime[4];
        scoreOutput.text = output;
    }
        
}