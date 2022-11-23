using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; //fetches components of player
    public Transform cameraPos; //calls the cameras position

    // Start is called before the first frame update
    // Update is called once per frame
    void Update() 
    {
        cameraPos.position = new Vector3 (cameraPos.position.x , player.position.y, cameraPos.position.z); //transforms the y position of the camera to the y position of the player
    }
}