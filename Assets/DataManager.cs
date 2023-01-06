using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DataManager : MonoBehaviour
{
    private bool finish;
    private float runTime;
    private float[] finalTime;
    private int numberOfEnemies = 6; //later change it so that the value depends on num of enemies in unity
    private int i = 1;
    void Start()
    {
        finalTime = new float[numberOfEnemies]; //initialise array
    }

    // Update is called once per frame
    void Update()
    {
        int exitCondition = 0;
        for (int enemy = 1; enemy <= numberOfEnemies; enemy++) {
            string enemyName = "Enemy (" + enemy + ")";
            var FinishLine = GameObject.Find(enemyName).GetComponent<FinishLine>();
            finish = FinishLine.passFinish; //sets finish to passFinish
            runTime = FinishLine.levelTimer; //run time equal to the levelTimer
            if (finish == true) { // only runs whilst finish line isnt crossed
                finalTime[enemy - 1] = runTime; // store the final time for this enemy in the array
                exitCondition++;
            } 
            if (exitCondition == 5){
                break;
            }
        }
        
        int i, j;
        float key;
        for (i = 1; i < finalTime.Length; i++){ // start at second element
            key = finalTime[i]; // store current element
            j = i - 1; // set index of previous element
            while (j >= 0 && finalTime[j] > key) // while previous element is larger than current element
            {
                finalTime[j + 1] = finalTime[j]; // shift previous element to the right
                j = j - 1; // move to next left element
            }
            finalTime[j + 1] = key; // insert current element into correct position
        }

        // print sorted array to console
        for (i = 0; i < finalTime.Length; i++)
        {
            Debug.Log(finalTime[i]);
        }
    
    } 
}
