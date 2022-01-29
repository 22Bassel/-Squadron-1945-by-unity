using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check_buttons_player : MonoBehaviour
{

    public share_data_sences data;
    public GameObject p1_color;
    public GameObject p2_color;

    bool player1;

    // Start is called before the first frame update
    void Start()
    {

        player1 = data.get_player();
        if (player1)
        {
            p1_color.SetActive(true);
            p2_color.SetActive(false);

        }
        else
        {

            p1_color.SetActive(false);
            p2_color.SetActive(true);

        }


    }

}
