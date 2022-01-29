using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_collision : MonoBehaviour
{
    // public string name_des;
    public GameObject smoke;
    void OnCollisionEnter(Collision col)
    {
        if (!col.collider.name.Contains("player"))
        {
            Instantiate(smoke, transform.position, Quaternion.identity);

            Destroy(gameObject);
            FindObjectOfType<Audio_Manger>().play("explosion_bullet");

        }
    }
}