using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class auto_move : MonoBehaviour
{
    bool m_r, m_l;
    // Start is called before the first frame update
    void Start()
    {
        m_r = true;
        m_l = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_r)
        {
            transform.position += transform.right * 100 * Time.deltaTime;
        }
        if (m_l)
        {
            transform.position -= transform.right * 100 * Time.deltaTime;

        }
        if (transform.position.x < -170)
        {
            m_r = false;
            m_l = true;
        }
        if(transform.position.x > 170)
        {
            m_l = false;
            m_r = true;
        }
    }
}
