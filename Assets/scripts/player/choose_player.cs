using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choose_player : MonoBehaviour
{
    bool player1;
    public share_data_sences data;
    public GameObject p1;
    public GameObject p2;

    // Start is called before the first frame update
    void Start()
    {
        player1 = data.get_player();
        //Debug.Log("sss"+ player1);
        if (player1) {
          //  Debug.Log("aa");
            p1.SetActive(true);
            p2.SetActive(false);
        }

        else
        {
            //Debug.Log("kkk");
            p1.SetActive(false);
            p2.SetActive(true);
        }
    }

   
}
