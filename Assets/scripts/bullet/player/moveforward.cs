using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveforward : MonoBehaviour
{
    public GameObject pause_mune;
    Vector3 start_point,final_point;
    public Vector3 offset;
   // public Mesh mr;
    // Start is called before the first frame update
    void Start()
    {
        start_point = transform.position;
       

        final_point = start_point +offset;
        transform.Rotate(Vector3.right * 90);

    }

    // Update is called once per frame
    void Update()
    {
        //if (pause_mune.active == false)
        {


            transform.position -= transform.up * 600 * Time.deltaTime;

            if (transform.position[2] <= final_point[2])
            {
                //mr.enabled(false);
                //Debug.Log("here !!");
                Destroy(gameObject);


            }
        }
    }
}
