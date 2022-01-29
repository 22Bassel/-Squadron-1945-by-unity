using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermotor : MonoBehaviour
{
    float start_fire;
    public GameObject fire;
    public Vector3 pos_fire1;
    public Vector3 pos_fire2;
    public player_sound_eff ps;
    //  public CharacterController controller;
    float speed = 250f;
    float side = 12f;
    bool w_r,w_l,w_w;  // for stop in bonder && start move
    bool s_r, s_l;     //for sound
                       // Start is called before the first frame update

    bool player1=false;
    public share_data_sences data;

    void Start()
    {
        w_r = false;
        w_l = false;
        w_w = false;
        s_r = false;
        s_l = false;
        start_fire = Time.time;
        player1= data.get_player();
        if (player1) { speed = 200f; side = 250f; }
        else { speed = 270f; side = 305f; }
    }

    // Update is called once per frame
    void Update()
    {

        transform.position -= transform.forward * speed * Time.deltaTime;
       // Debug.Log("hit  !!" + transform.position);
        if (Input.GetKey("w"))
        {
            if (w_w)
            {
                ps.forward();
                transform.position -= transform.forward * speed * Time.deltaTime;
                if (!Input.GetKey("a") && !Input.GetKey("d") && Time.time > start_fire + 0.7f)
                {
                    start_fire = Time.time;
                    Instantiate(fire, transform.position + pos_fire1, Quaternion.identity);
                    Instantiate(fire, transform.position + pos_fire2, Quaternion.identity);
                }
            }
        }
        /**else
        {
            Debug.Log("hit  !!"+4654654);
            ps.noforward();

        }**/

        if (Input.GetKey("a"))
        {
            if (w_l)
            {
                if (!s_l)
                {
                    ps.slide();
                    s_l = true;
                    s_r = false;
                }
                transform.position += transform.right * side * Time.deltaTime;
                transform.Rotate(Vector3.forward * 20 * Time.deltaTime);
                //if r_w flase from collision
                w_r = true;
            }
        }

        if (Input.GetKey("d"))
        {
            if (w_r)
            {

                if (!s_r)
                {
                    ps.slide();
                    s_r = true;
                    s_l = false;
                }

                transform.position -= transform.right * side * Time.deltaTime;
                transform.Rotate(Vector3.back * 20 * Time.deltaTime);
                //if r_l flase from collision
                w_l = true;
            }
        }
       /** 
        if (Input.GetKey("e"))
        {
            
        transform.Rotate(Vector3.right * 20 * Time.deltaTime);

        }

        if (Input.GetKey("q"))
        {

            transform.Rotate(Vector3.left * 20 * Time.deltaTime);
        }
    **/
    }
    
    public void no_walk_right()
    {
        w_r = false;

    }


    public void no_walk_left()
    {
        w_l = false;
    }


    public void start_walk()
    {
        w_r = true;
        w_l = true;
        w_w = true;
    }


}
