using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health_player : MonoBehaviour
{
    public float num_health;
    public health_updata hp;
    public GameObject fire;
    public GameObject smoke;
    public playermotor pm;
    public player_sound_eff ps;

    public Vector3 pos1;
    public Vector3 pos2;
    bool die;
    float time_die;

    public GameObject game_over;
    // Start is called before the first frame update
    void Start()
    {
        num_health = 100;
        die = false;
    }

    void Update()
    {
        if (die)
        {
            if (!(Time.time >= time_die + 2))
            {

                //transform.position -= transform.right * 30 * Time.deltaTime;

                transform.position -= transform.up * 20 * Time.deltaTime;
                transform.position -= transform.forward * 150 * Time.deltaTime;

            }

            else
            {
                //FindObjectOfType<Audio_Manger>().stop("bomb");

                Instantiate(smoke, transform.position, Quaternion.identity);
                Destroy(gameObject);
                game_over.SetActive(true);
            }
        }
    }


        void OnCollisionEnter(Collision col)
    {
        //Debug.Log("hit  !!"+8888);
        if (!die)
        {
            if (col.collider.name.Contains("shooting_e"))
            {
                num_health -= 5;
                hp.new_health();

            }

            if (col.collider.tag=="enemy" || num_health <= 0)
            {
                //Debug.Log("health "+ num_health);
                Instantiate(fire, transform.position + pos1, Quaternion.identity);
                Instantiate(fire, transform.position + pos2, Quaternion.identity);
                die = true;
                time_die = Time.time;
                ps.die();

                hp.die();
                pm.enabled=false;
            }

            
            

        }
    }
}