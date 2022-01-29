using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check_buttons_diffcalty : MonoBehaviour
{

    public share_data_sences data;
    public GameObject p1;
    public GameObject p2;

    // Start is called before the first frame update
    void Start()
    {

        bool d1 = data.diff();
        if (d1)
        {
            p1.SetActive(true);
            p2.SetActive(false);
        }
        else
        {
            p1.SetActive(false);
            p2.SetActive(true);
        }

    }
}
    

