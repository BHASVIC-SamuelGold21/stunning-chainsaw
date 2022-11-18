using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player; //fetches components of player
    private Vector3 cameraPos; //calls the cameras position

    // Start is called before the first frame update
    void Start()
    {
      Vector3 playerPos = transform.position - player.transform.position; //subtracts the position of camera from the player to find the offset
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
