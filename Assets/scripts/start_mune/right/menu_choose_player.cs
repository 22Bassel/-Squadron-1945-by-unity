using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_choose_player : MonoBehaviour
{
    public share_data_sences data;
    public GameObject p1_color;
    public GameObject p2_color;

    public void choose_1()
    {
        p1_color.SetActive(true);
        p2_color.SetActive(false);
        data.player1();
    }

    public void choose_2()
    {
        p1_color.SetActive(false);
        p2_color.SetActive(true);
        data.player2();

    }


}
