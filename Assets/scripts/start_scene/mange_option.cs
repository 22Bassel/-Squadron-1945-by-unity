using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mange_option : MonoBehaviour
{
    public Audio_Manger a_m;
    public GameObject sound_b;
    public GameObject no_sound_b;

    public GameObject music_b;
    public GameObject no_music_b;

    public GameObject diff1;
    public GameObject diff2;

    public share_data_sences data;
    bool sound = true;
    bool music = true;
    public void click_sound()
    {
        if (sound)
        {
            sound_b.SetActive(false);
            no_sound_b.SetActive(true);

            data.no_sounds();
            sound = false;
        }
        else
        {
            sound_b.SetActive(true);
            no_sound_b.SetActive(false);

            data.re_sounds();
            sound = true;
        }
        //a_m.no_sound();

    }

    public void click_music()
    {
        if (music)
        {
            music_b.SetActive(false);
            no_music_b.SetActive(true);

            data.no_music();

            a_m.no_music_m();

            music = false;
        }
        else
        {
            music_b.SetActive(true);
            no_music_b.SetActive(false);

            data.re_music();
            a_m.re_music_m();
            music = true;
        }
        //a_m.no_sound();

    }

    public void click_d1()
    {
        diff1.SetActive(true);
        diff2.SetActive(false);
        data.diff_1();
    }
    public void click_d2()
    {
        diff1.SetActive(false);
        diff2.SetActive(true);
        data.diff_2();
    }
}
