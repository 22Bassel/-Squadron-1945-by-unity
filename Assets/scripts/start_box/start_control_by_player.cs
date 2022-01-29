using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_control_by_player : MonoBehaviour
{
    public GameObject player;
    public GameObject start_ui;
    public shooting s;

    bool ins = true;
    playermotor player_motor;

    public game g;
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("here 222333");
        if (ins)
        {

            if (col.collider.name.Contains("player"))
            {

                player_motor = player.GetComponent(typeof(playermotor)) as playermotor;

                Debug.Log("hit  222333444");

                player_motor.start_walk();
                s.enabled = true;
                start_ui.SetActive(false);
                ins = false;
                g.start_time_fun();
            }
        }
    }
}