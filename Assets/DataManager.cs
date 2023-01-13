using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DataManager : MonoBehaviour
{
    public float[] finalTime;
    public string[] enemyOrder;
    public bool sorted = false;
    public bool finish;
    private float runTime;
    private float runTimePlayer;
    private int numberOfEnemies = 6; //later change it so that the value depends on num of enemies in unity
    private int i;
    public bool exit = false;
    void Start()
    {
        finalTime = new float[numberOfEnemies]; //initialise array
        enemyOrder = new string[6] {"Enemy (1)", "Enemy (2)", "Enemy (3)", "Enemy (4)", "Enemy (5)", "Player"}; //initialise array with names of all enemies
    }

    // Update is called once per frame
    void Update()
    {
        
        int exitCondition = 0;
        int enemy = 1;
        while (enemy <= numberOfEnemies && exit == false) {
            string enemyName = "Enemy (" + enemy + ")";
            var FinishLine = GameObject.Find(enemyName).GetComponent<FinishLine>();
            var FinishLinePlayer = GameObject.Find("Player").GetComponent<FinishLine>();
            finish = FinishLine.passFinish; //sets finish to passFinish
            finish = FinishLinePlayer.passFinish;
            runTime = FinishLine.levelTimer; //run time equal to the levelTimer
            runTimePlayer = FinishLinePlayer.levelTimer;
            if (finish == true) { // only runs whilst finish line isnt crossed
                finalTime[enemy - 1] = runTime; // store the final time for this enemy in the array
                
                exitCondition++;
            } 
            if (exitCondition == 5){
                finalTime[6] = runTimePlayer;
                exit = true;
            }
            enemy++;
        }
        
        int i = 1;
        int j;
        float key;
        string key1;
        while (i < finalTime.Length){ // start at second element
            key = finalTime[i]; // store current element
            key1 = enemyOrder[i];
            j = i - 1; // set index of previous element
            while (j >= 0 && finalTime[j] > key) // while previous element is larger than current element
            {
                finalTime[j + 1] = finalTime[j]; // shift previous element to the right
                enemyOrder[j + 1] = enemyOrder[j];
                j = j - 1; // move to next left element
            }
            finalTime[j + 1] = key; // insert current element into correct position
            enemyOrder[j + 1] = key1; 
            i++;
        }
        

        
    } 
}