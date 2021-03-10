using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public float HP;
    public bool Alive;
    // Start is called before the first frame update
    void Start()
    {
        HP = 8f;
        Alive = true;
    }

    // Update is called once per frame

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "redOrb")
        {
            HP -= 1f;
            Destroy(coll.gameObject);

        }
        if (HP <= 0)
        {
            Destroy(this.gameObject);
        }
        if (coll.gameObject.tag == "pinkOrb")
        {
            HP -= 1f;
            Destroy(coll.gameObject);

        }
        if (HP <= 0)
        {
            FindObjectOfType<GameManager>().EndGame();
            Destroy(this.gameObject);

        }

    }
}
