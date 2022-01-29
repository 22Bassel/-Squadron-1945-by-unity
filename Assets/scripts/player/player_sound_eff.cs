using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_sound_eff : MonoBehaviour
{

    bool isdie;
    bool check;
    // Start is called before the first frame update
    bool player1 = false;

    public share_data_sences data;

    void Start()
    {
        player1 = data.get_player();
        if (player1)
        {
            FindObjectOfType<Audio_Manger>().play("plane_first");
        }
        else
        {
            FindObjectOfType<Audio_Manger>().play("player2");
        }
        isdie = false;
        check = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isdie)
        {
            if (!FindObjectOfType<Audio_Manger>().isplaying("plane_first") && !FindObjectOfType<Audio_Manger>().isplaying("plane_second") && player1)
            {
                FindObjectOfType<Audio_Manger>().play("plane_second");
                //FindObjectOfType<Audio_Manger>().play("p2");
            }

            if (!FindObjectOfType<Audio_Manger>().isplaying("player2") && !FindObjectOfType<Audio_Manger>().isplaying("player2_second") && !player1)
            {
                //Debug.Log("asdasd");
                 FindObjectOfType<Audio_Manger>().play("player2_second");
                //FindObjectOfType<Audio_Manger>().play("p2");
            }
        }
    }
    public void slide()
    {

        if (!FindObjectOfType<Audio_Manger>().isplaying("plane_first") && !FindObjectOfType<Audio_Manger>().isplaying("plane_second"))
        {

            FindObjectOfType<Audio_Manger>().stop("slide");

            FindObjectOfType<Audio_Manger>().play("slide");
        }
        else {
            FindObjectOfType<Audio_Manger>().play("slide");
        }

    }

    public void forward()
    {
    //    Debug.Log("hit  !!" + 99);

        if (!FindObjectOfType<Audio_Manger>().isplaying("power") )
        {
            //Debug.Log("hit2233  !!");

            FindObjectOfType<Audio_Manger>().play("power");

        }

    }

    public void noforward()
    {
        //Debug.Log("hit  !!" + 89);

        /**
        if (FindObjectOfType<Audio_Manger>().isplaying("power"))
        {

            FindObjectOfType<Audio_Manger>().stop("power");
            check = true;
        }
    **/
    }

    public void die()
    {
        isdie = true;
        FindObjectOfType<Audio_Manger>().stop("plane_second");
        FindObjectOfType<Audio_Manger>().stop("plane_first");
        FindObjectOfType<Audio_Manger>().stop("player2");
        FindObjectOfType<Audio_Manger>().stop("player2_second");

        FindObjectOfType<Audio_Manger>().play("bomb");

    }



}
