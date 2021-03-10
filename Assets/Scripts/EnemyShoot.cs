using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public float ran;
    // creates a float so indicate a random number
    public GameObject bulletPrefab;
    // calles a prefab named bulletPrefab
    public float shootdelay;
    // makes the enemy's have to spend time to shoot again.
    void Start()
    {
        shootdelay = 200f;
        // makes every enemy start with 200 units of time when intantiated
    }

    void Update()
    // void Update makes it so these actions below are called every frame
    {
        ran = Random.Range(160, 200);
    // uses the variable ran created on line 7 to make a number inbetween 160 and 200

        shootdelay -= 1f;
    // because it is put under void Update this will make the shootdelay on line 15 decrease by 1 per frame.
        if (shootdelay == 0)
    // activated the line below if the variable shootdelay is 0
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
    // creates a bulletPrefab
            shootdelay = ran;
    // randomizes the shootdelay
        }
    }
}
