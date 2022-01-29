using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_collision_enemy : MonoBehaviour
{
    public GameObject smoke;
    void OnCollisionEnter(Collision col)
    {

        if (!col.collider.name.Contains("enemy"))
        {
            Instantiate(smoke, transform.position, Quaternion.identity);
            Debug.Log("dd"+ col.collider.name);
            Destroy(gameObject);
            if (col.collider.name.Contains("player"))
            {       FindObjectOfType<Audio_Manger>().play("explosion_bullet2");
        }
        }
    }
}
