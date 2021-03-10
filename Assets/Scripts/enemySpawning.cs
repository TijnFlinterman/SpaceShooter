using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawning : MonoBehaviour
{
    public int waves;
    // identifies the amount of waves I have
    public int Enemy;
    // gives me a limit i can set for how many enemy's spawn.
    public float Ran;
    // creates ran variable
    public bool spawn;
    // makes a true of false bool for when the enemys can spawn
    public float time;
    // gives me a variable of time i can change.
    public GameObject Wheel;
    // makes me able to instantiate the enemy


    // Start is called before the first frame update
    void Start()
    {

        spawn = true;
        // setting spawn true so that if i start the game the enemy's start spawning
        Enemy = 0;
        // sets the standart amount of enemys at 0
        waves = 1;
        // sets the wave to 1
        time = 80;
        // i give the variable time an amount of 80
    }

    // Update is called once per frame
    void Update()
    {

        Ran = Random.Range(-7f, 7f);
        // creates a random variable names Ran inbetween -7 and 7
        if (spawn == true)
        {
           
            Instantiate(Wheel, new Vector3(Ran, 3.8f, -0.34f), Quaternion.identity);
            Enemy += 1;
        }
        if (waves == 1)
        {
            if (Enemy == 4)
            {
                spawn = false;
                time = 80;
            }
        }
        if (waves == 2)
        {
            if (Enemy == 5)
            {
                time = 80;
                spawn = false;
            }
        }
        if (waves == 3)
        {
            if (Enemy == 6)
            {
                time = 80;
                spawn = false;
            }
        }
        if (waves == 4)
        {
            if (Enemy == 7)
            {
                time = 80;
                spawn = false;
            }
        }
            if (Enemy <= 0)
            time -= 1;
        {
            if (time == 0)
            {
                time = 80;
                spawn = true;
                waves += 1;
            }
        }
    }
}
