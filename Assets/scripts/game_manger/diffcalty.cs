using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diffcalty : MonoBehaviour
{ 
    public GameObject enmy_d2;
    public GameObject obst_d2;
    //public GameObject []obst;

    public share_data_sences data;

    // Start is called before the first frame update
    void Start()
    {
       bool d1= data.diff();

        if (!d1)
        {
            enmy_d2.SetActive(true);
            obst_d2.SetActive(true);
        }
        else
        {
            enmy_d2.SetActive(false);
            obst_d2.SetActive(false);
        }
    }
    
}
