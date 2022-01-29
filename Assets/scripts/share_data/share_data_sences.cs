using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class share_data_sences : MonoBehaviour
{

    bool sounds = true;
    bool music = true;
    bool is_player1 =true;
    bool difficulty1 = true;
    public void player1()
    {
        is_player1 = true;
    }

    public void player2()
    {
        is_player1 = false;
    }
    
    public bool get_player()
    {
    //    is_player1 = true;
        Debug.Log("qqqq"+ is_player1);
        return is_player1;
    }

    public void no_sounds()
    {
        sounds = false;
    }

    public void re_sounds()
    {
        sounds = true;
    }
    public bool get_sounds()
    {
        return sounds;
    }


    public void no_music()
    {
        music = false;
    }

    public void re_music()
    {
        music = true;
    }
    public bool get_music()
    {
        return music;
    }
    public void diff_1()
    {
        difficulty1 = true;
    }
    public void diff_2()
    {
        difficulty1 = false;
    }
    public bool diff()
    {
        if (difficulty1) { return true; }
        else
        {
            return false;
        }
    }
}
