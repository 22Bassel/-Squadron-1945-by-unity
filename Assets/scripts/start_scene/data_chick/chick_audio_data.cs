using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chick_audio_data : MonoBehaviour
{
    public share_data_sences data;

    // Start is called before the first frame update
    void Start()
    {

        bool sound = data.get_sounds();
        // Debug.Log("sound"+sound);
        if (!sound)
        {
            FindObjectOfType<mange_option>().click_sound();
            
        }

        bool music = data.get_music();
        // Debug.Log("sound"+sound);
        if (!music)
        {
            FindObjectOfType<mange_option>().click_music();

        }

    }


}
