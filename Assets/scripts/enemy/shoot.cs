using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform player;
    public GameObject bullet;
    public float ratefire;
    private float nextfire;
    bool r_l; // right or left bullet
    public Vector3 pos1;
    public Vector3 const_pos;

    List<GameObject> all_bull = new List<GameObject>();
    bool is_exist=false;
    // Start is called before the first frame update
    void Start()
    {
        r_l = false;
        ratefire = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            if ((transform.position.z + 1800) >= player.position.z && (transform.position.z - 50) <= player.position.z)
            {
                if (Time.time > nextfire)
                {
                    if (!r_l)
                    {
                        GameObject b1 = Instantiate(bullet, transform.position + pos1 + const_pos, Quaternion.identity);
                        r_l = true;
                        is_exist = true;
                        all_bull.Add(b1);
                       // all_bull.Add(b2);

                    }
                    else
                    {
                        GameObject b2 = Instantiate(bullet, transform.position - pos1 + const_pos, Quaternion.identity);
                        r_l = false;
                        is_exist = true;

                        all_bull.Add(b2);

                    }
                    // Instantiate(bullet, transform.position + pos2, Quaternion.identity);
                    //FindObjectOfType<Audio_Manger>().play("rocket");
                    nextfire = Time.time + ratefire;

                }
            }
        }
    }


    public List<GameObject> get_bull_list()
    {
        if (!is_exist) {
           // Debug.Log("no");
            return null; }
        return all_bull;
    }
}
