using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullethit : MonoBehaviour
{
    public float HP;
    // makes a variable for the enemy's health
    public GameObject enemyRotate;
    // to call the variable from a diffirent script
    public float ran;
    // ran is random number for the enemy's
    void Start()
    {
        HP = 5f;
        // makes the enemy spawn with 5 points for health standant
    }

    void Update()
    {
        ran = Random.Range(10, 30f);
        // makes a random number inbetween 10 to 30
        if(enemyRotate.GetComponent<EnemyShoot>().shootdelay == 1f)
        // get the variable shootdelay from script shootdelay
        {
            
            transform.Rotate(0,0,ran);
            // makes enemy rotate by using the random number made in line 21
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
        // makes a void, if i call this void it will do everything under the {}
    {
        if (coll.gameObject.tag == "bullet")
            // if make contact with a gameObject with the tag "bullet" get -health
        {
            HP -= 1f;
            Destroy(coll.gameObject);
            // Destroys the gameObject it makes contact with.
        }
        if (HP <= 0)
        {
            Destroy(this.gameObject);
            GameObject.Find("Main Camera").GetComponent<enemySpawning>().Enemy -= 1;

            // makes it so if the health is or is under 0 the gameObject this script is on gets destroyed.
        }

    }
}
