using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health_updata : MonoBehaviour
{
    public Vector3 temp;
    //public health_updata r;  
    public GameObject r;

    public void new_health()
    {
        transform.localScale -= temp;

        transform.position -= 11.8f*transform.right;
    }

    public void die()
    {
        r.SetActive( true);
        Destroy(gameObject);        
    }

}
