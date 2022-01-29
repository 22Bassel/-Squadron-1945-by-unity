using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_bullet_elec : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (!col.collider.name.Contains("player"))
        {

            Destroy(gameObject);

        }
    }
}
