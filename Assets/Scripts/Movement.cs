using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-movementSpeed, 0, 0, Space.World);
    // Spaceworld takes the X,Y,Z coördinates of the scene and not of the player when he rotates
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(movementSpeed, 0, 0, Space.World);
    // Spaceworld takes the X,Y,Z coördinates of the scene and not of the player when he rotates
        }
        if (Input.GetKey(KeyCode.W))
        {
           transform.Translate(0,movementSpeed, 0, Space.World);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -movementSpeed, 0, Space.World);
        }
    } 
}
