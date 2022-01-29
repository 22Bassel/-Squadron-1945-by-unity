using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

using UnityEngine;

public class pause_mune_action : MonoBehaviour
{
    bool sounds = true;
    public Audio_Manger audio;
    public GameObject sound_text;
    public GameObject no_sound_text;
    
    public share_data_sences data;


    public void change_sounds()
    {
       // Audio_Manger a = gameObject.GetComponent(typeof(Audio_Manger)) as Audio_Manger;
            
            
        if (sounds)
        {
            sound_text.SetActive(false);
            no_sound_text.SetActive(true);
            audio.no_sound();
            sounds = false;
            data.no_sounds();
        }
        else
        {

            sound_text.SetActive(true);
            no_sound_text.SetActive(false);
            audio.re_sound();
            sounds = true;
            data.re_sounds();
        }


    }
    
    
    public void quit()
    {
        second();
        SceneManager.LoadScene("start__scence");
    }


    IEnumerator second()
    {
        yield return new WaitForSeconds(2);
    }

}
