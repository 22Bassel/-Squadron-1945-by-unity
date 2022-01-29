using UnityEngine.Audio;
using UnityEngine;

using System;

public class Audio_Manger : MonoBehaviour
{
    private bool no_sounds=false;
    private bool no_music = false;

    public sound[] sounds;
    bool[] is_pause=new bool[20];
    int num_sound=0;
    bool is_pause_game=false;
    // Start is called before the first frame update
    void Awake()
    {
        foreach (sound s in sounds){

            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.number = num_sound;
            //is_pause[num_sound] = new bool();
            is_pause[num_sound] = false;
            num_sound++;

        }


    }

    public void play(string name)
    {
        if(no_music && name == "click") { return; }
        if (no_music && name == "song") { return; }

        //  Debug.Log("play "+ no_sounds);
        if (!is_pause_game && !no_sounds)
        {
            //Debug.Log("play " + no_sounds);
            sound s = Array.Find(sounds, sound => sound.name == name);
            s.source.Play();

        }

        if(is_pause_game && name == "click")
        {
            sound s = Array.Find(sounds, sound => sound.name == name);
            s.source.Play();

        }
    }


    public void stop(string name)
    {
        sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Stop();
    }


    public bool isplaying(string name)
    {
        sound s = Array.Find(sounds, sound => sound.name == name);
        if (s.source.isPlaying) {
            return true;
        }
        return false;
    }


    public void pause_all()
    {
        is_pause_game = true;
        foreach (sound s in sounds)
        {
            if (s.source.isPlaying)
            {
      //          Debug.Log("puase sound = "+s.name);
                s.source.Pause();
                is_pause[s.number] = true;
            }
        }
    }

    public void resume_all()
    {
        if (!no_sounds)
        {
            foreach (sound s in sounds)
            {
    //            Debug.Log("res sound = " + s.name);

                if (is_pause[s.number])//is puase
                {
                    s.source.Play();
                    is_pause[s.number] = false;
                }
            }
        }
        else {

            foreach (sound s in sounds)
            {
                if (is_pause[s.number] && s.name != "plane_first")//is puase
                {
                    s.source.Stop();
                    is_pause[s.number] = false;
                }
            }
        }
            is_pause_game = false;
        
    }


    
    public void no_sound()
    {
        Debug.Log("no_sound ");
        no_sounds = true;

    }

    public void re_sound()
    {

        no_sounds = false;

    }

    public void no_music_m()
    {
        //Debug.Log("no_sound ");
        no_music = true;
        stop("song");
        

    }

    public void re_music_m()
    {
        no_music = false;
        play("song");
        
    }



}
