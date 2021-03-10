using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinkHitreg : MonoBehaviour
{
    public float time;
    public GameObject BpinkOrb;
    public float HP;
    void Start()
    {
        HP = 1f;
        time = 3f;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "bullet")
        {
            HP -= 1f;
            Destroy(coll.gameObject);

        }
        if (HP <= 0)
        {
            Destroy(this.gameObject);
            Instantiate(BpinkOrb, transform.position, transform.rotation);
        }

    }
}