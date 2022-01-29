using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public GameObject fire;
    public GameObject smoke;
    public shoot s;
    public float num_health;
    public Vector3 pos1;
    public Vector3 pos2;
    public Vector3 pos3;
    public Vector3 pos4;

    bool die;
    float time_die;

    public game g;
    // Start is called before the first frame update
    void Start()
    {
      

        die = false;
        num_health = 100;
    }

    void OnCollisionEnter(Collision col)
    {
        //    Debug.Log("hit  !!" + 369);

        if (!die)
        {
            if (col.collider.name.Contains("player"))
            {
                FindObjectOfType<Audio_Manger>().play("explosion");
                Instantiate(smoke, transform.position + pos4, Quaternion.identity);

                Destroy(gameObject);
            }

            if (col.collider.name.Contains("bullet"))
            {
                num_health -= 25;
                g.increase_score_bullet();

                //Debug.Log("hit  !!" + num_health);

            }
            if (num_health <= 0)
            {
                //Debug.Log("hit  !!" + num_health);

                time_die = Time.time;
                die = true;

                Instantiate(fire, transform.position + pos1, Quaternion.identity);
                Instantiate(fire, transform.position + pos2, Quaternion.identity);
                Instantiate(fire, transform.position + pos3, Quaternion.identity);

                s.enabled = false;
                g.increase_score_enemy();

            }
        }
    }

    void Update() {
        if (die) { 
            if (Time.time >= time_die + 0.2)
            {
                FindObjectOfType<Audio_Manger>().play("explosion");
                Instantiate(smoke, transform.position+pos4, Quaternion.identity);
                
                Destroy(gameObject);
            }

        }

    }


}
