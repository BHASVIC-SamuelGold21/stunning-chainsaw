using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visability : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(10000, 5000, 0); //transforms to x coord

    }

    // Update is called once per frame
    void Update()
    {
        var dataManager = GameObject.Find("Data Manager").GetComponent<finishMonitor>();
        if(dataManager.allFinish == true){
            transform.position = new Vector3(448, 373, 0); //transforms to x coord to 0
        }
    }
}   