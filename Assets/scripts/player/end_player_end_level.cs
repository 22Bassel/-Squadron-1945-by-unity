using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end_player_end_level : MonoBehaviour
{
    bool end;
    float start;
    public followplayer camera;

    void Start()
    {
        end = false;
    }

    void OnCollisionEnter(Collision col)
    {
        //Debug.Log("hit  !!" + 789);

        if (col.collider.name.Contains("Sparks"))
        {
          //  Debug.Log("hit  !!" + 789789);

            end = true;
            start = Time.time;
        }
    }
        // Start is called before the first frame update
       

    // Update is called once per frame
    void Update()
    {
        if (end)
        {
            if (Time.time >= start + 0.7)
            {
                
                Destroy(gameObject);
            }
        }
    }
}
