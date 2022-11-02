using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public int randomNumber = Random.Range(0, 9);
public class Spawn : MonoBehaviour
{

    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, randomNumber, 0);
    }
}
