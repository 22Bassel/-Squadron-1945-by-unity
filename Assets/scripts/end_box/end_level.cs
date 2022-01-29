using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end_level : MonoBehaviour
{
    public GameObject magic;
    public game gm;

    public Transform player;
    public shooting s;
    playermotor player_motor;
    bool in_p=false;

    // Start is called before the first frame update
    void OnCollisionEnter(Collision col)
    {
       // Debug.Log("hit  !!" + 55556666);

        if (!in_p)
        {

            if (col.collider.name.Contains("player"))
        {       Vector3 pos = new Vector3(player.position.x, player.position.y, -6250f);
                Instantiate(magic, pos, Quaternion.identity);
                player_motor = player.GetComponent(typeof(playermotor)) as playermotor;
                player_motor.no_walk_right();
                player_motor.no_walk_left();
                s.enabled = false;
                in_p = true;
                gm.complete_evel();

         }


        }
    }

}
