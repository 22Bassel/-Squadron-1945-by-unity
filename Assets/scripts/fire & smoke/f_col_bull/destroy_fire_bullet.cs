using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_fire_bullet : MonoBehaviour
{
    private float start;
    // Start is called before the first frame update
    void Start()
    {
        start = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > start + 0.15)
        {
            Destroy(gameObject);
        }
    }

}
