using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_fire : MonoBehaviour
{
    private float start_time;
    // Start is called before the first frame update
    void Start()
    {
        start_time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time < start_time + 2)
        {
            //transform.position -= transform.right * 30 * Time.deltaTime;

            transform.position -= transform.up * 20 * Time.deltaTime;
            transform.position -= transform.forward * 150 * Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);

        }
    }
}
