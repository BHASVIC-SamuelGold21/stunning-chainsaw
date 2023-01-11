using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EndScreen : MonoBehaviour
{
    public TMP_Text ranking;
    private string output;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(1000, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        var DataManager = GameObject.Find("Data Manager").GetComponent<DataManager>();
        string output = "1st: " + DataManager.enemyOrder[0] + " - " + DataManager.finalTime[0] + "\n2nd: " + DataManager.enemyOrder[1] + " - " + DataManager.finalTime[1] + "\n3rd: " + DataManager.enemyOrder[2] + " - " + DataManager.finalTime[2] + "\n4th: " + DataManager.enemyOrder[3] + " - " + DataManager.finalTime[3] + "\n5th: " + DataManager.enemyOrder[4] + " - " + DataManager.finalTime[4] + "\n";
        if(DataManager.finish == true){
            ranking.text = output;
        }
    }
}
