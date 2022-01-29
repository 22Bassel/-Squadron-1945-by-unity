using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end_time : MonoBehaviour
{
    public game g;
    //float i = 0;
    // Start is called before the first frame update
    void Start()

    {
        if (g != null)
        {
           // Debug.Log("hs" + i);
            // game g = game_manger.GetComponent(typeof(game)) as game;
            g.stop_time();
          //  Debug.Log("h9");
         //   i++;
        }
    }

   
}
