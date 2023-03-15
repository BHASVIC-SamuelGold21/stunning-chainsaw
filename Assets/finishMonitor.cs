using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishMonitor : MonoBehaviour
{
    public bool allFinish;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var player = GameObject.Find("Player").GetComponent<FinishLine>();
        var enemy1 = GameObject.Find("Enemy (1)").GetComponent<FinishLine>();
        var enemy2 = GameObject.Find("Enemy (2)").GetComponent<FinishLine>();
        var enemy3 = GameObject.Find("Enemy (3)").GetComponent<FinishLine>();
        var enemy4 = GameObject.Find("Enemy (4)").GetComponent<FinishLine>();
        var enemy5 = GameObject.Find("Enemy (5)").GetComponent<FinishLine>();
        if (enemy1.passFinish == true && enemy2.passFinish == true && enemy3.passFinish == true && enemy4.passFinish == true && enemy5.passFinish == true && player.passFinish == true) {
            allFinish = true;
        }
        
    }
}
