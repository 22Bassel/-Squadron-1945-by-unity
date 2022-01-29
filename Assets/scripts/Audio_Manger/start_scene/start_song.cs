using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_song : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<Audio_Manger>().play("song");

    }

    // Update is called once per frame
    void Update()
    {
        if (!(FindObjectOfType<Audio_Manger>().isplaying("song")))
            {

            FindObjectOfType<Audio_Manger>().play("song");

        }

    }
}
