using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class not_walk_left : MonoBehaviour
{

    public GameObject player;

    playermotor player_motor;

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.name.Contains("player"))
        {

            player_motor.no_walk_left();

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        player_motor = player.GetComponent(typeof(playermotor)) as playermotor;

    }


}
