using System.Collections;
using UnityEngine;

public class bulletTravel : MonoBehaviour
{

     public float bulletSpeed = 0.07f;
    // public float for a speed that the bullet moves
    public float time;
    // makes a float for the decay of the bullet.
    void Start()
    {
        time = 400;
        //makes every bullet start with 400 units of time when instanciated
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,bulletSpeed,0);
        // makes the bullet travel with the variable bulletSpeed made in line 7

        time -=1;
        // makes the time go down per frame
        if (time <= 0)
        // if statement which detects if time is, or is under 0
        {
            Destroy(gameObject);
        // destroy the gameObject this script is on.
        }
    }

}
