using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreenBackground : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(15000,-15000,0); //transforms background offscreen
    }

    // Update is called once per frame
    void Update()
    {
        var DataManager = GameObject.Find("Data Manager").GetComponent<DataManager>(); //get DataManager script components
        if(DataManager.exit == true){ //run when games finishes
            transform.position = new Vector3(500,300,0); //transforms background onscreen
        }

    }
}
