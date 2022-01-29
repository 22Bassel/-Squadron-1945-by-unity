using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public GameObject bullet;
    public GameObject elc_bullet;

    private float ratefire;
    private float nextfire;
    public Vector3 pos1;
    public Vector3 pos2;
    List<GameObject> all_bull = new List<GameObject>();
    bool is_exist = false;

    bool player1=false;
    public share_data_sences data;
    // Start is called before the first frame update

    void Start()
    {
        player1 = data.get_player();
        if (player1)
        {
            ratefire = 0.2f;
        }
        else
        {
            ratefire = 0.05f;
        }
        nextfire = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("g"))
        {
            if (Time.time > nextfire)
            {
                GameObject b1, b2;
                if (player1)
                {

                    b1 = Instantiate(bullet, transform.position + pos1, Quaternion.identity);
                    b2 = Instantiate(bullet, transform.position + pos2, Quaternion.identity);
                   // Debug.Log("shoot !! ");
                    FindObjectOfType<Audio_Manger>().play("rocket");
                }
                else
                {
                    b1 = Instantiate(elc_bullet, transform.position + pos1, Quaternion.identity);
                    b2 = Instantiate(elc_bullet, transform.position + pos2, Quaternion.identity);

                    FindObjectOfType<Audio_Manger>().play("ele_bullet");
                }
                nextfire = Time.time + ratefire;
                is_exist = true;
                all_bull.Add(b1);
                all_bull.Add(b2);
            }
        }
    }

    public List<GameObject> get_bull_list()
    {
        if (!is_exist)
        {
            //Debug.Log("no");
            return null; }
        return all_bull;
    } 

}