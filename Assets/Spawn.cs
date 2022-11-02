using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Spawn : MonoBehaviour
{
    //This Scipt is for assigning a random starting location for the player
    void Start()
    {
        int randomNumber = Random.Range(-9, 9); //random number between -9 and 9
        transform.position = new Vector3(randomNumber, 0, 0); //transforms to x coord of random number

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
