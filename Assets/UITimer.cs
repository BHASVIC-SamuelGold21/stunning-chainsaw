using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UITimer : MonoBehaviour
{
    public TMP_Text playerTimer;
    public float runTime;
    private string strngRunTime;

    // Start is called before the first frame update
    void Start()
    {
        var FinishLine = GameObject.Find("Player").GetComponent<FinishLine>();
        runTime = FinishLine.levelTimer;
    }
    

    // Update is called once per frame
    void Update()
    {

        strngRunTime = runTime.ToString();
        playerTimer.text = strngRunTime;
    }
}
