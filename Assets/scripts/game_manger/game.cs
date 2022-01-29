using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class game : MonoBehaviour
{
    public GameObject level_com;
    public GameObject pause_mune;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;

    public GameObject enemy4;
    public GameObject enemy5;

    public Audio_Manger audio;
    bool isclick = false;
    public playermotor p_m;
    public shooting s_p;
    [SerializeField]
    public shoot s_e1;
    public shoot s_e2;
    public shoot s_e3;

    public shoot s_e4;
    public shoot s_e5;

    public auto_move a_m;
    public auto_move a_m2;

    public followplayer f_p;
    //public moveforward m_f_bullet;
    public move m_bull_enemy;
    float time_click =0;
    float start_time;
    public share_data_sences data;

    public Text time_txt;
    float time;
    bool stop_time_p = false;
    bool start_time_num = false;
    public Text score_txt;

    public move shooting_enemy;
    public moveforward shooting_enemy_ele;


    bool dif1=true;

    bool no_pause;
    void Start()
    {
         dif1 = data.diff();
        bool sound =data. get_sounds();
       // Debug.Log("sound"+sound);
        if (!sound)
        {
            audio.no_sound();
            (pause_mune.GetComponent(typeof(pause_mune_action)) as pause_mune_action).change_sounds();
            
        }

        bool music = data.get_music();
        // Debug.Log("sound"+sound);
        if (!music)
        {
            audio.no_music_m();
          
        }
        start_time = Time.time;
        time = 0;

        shooting_enemy.enabled = true;
        shooting_enemy_ele.enabled = true;

        no_pause = false;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape) && Time.time>time_click+0.5 && !no_pause)
        {
            //Debug.Log("hit  !!" + 852);

            time_click = Time.time;
            if (!isclick)
            {
            //    Debug.Log("esc");
                pause();
                isclick = true;
            }
            else
            {
                resume();
                isclick = false;
            }
        }
        //Debug.Log("h11" + stop_time_p);
        
        //for time
        if (start_time+1 <= Time.time && !isclick && !stop_time_p && start_time_num)
        {
            time += 1;
            time_txt.text = "time : " + time;
            start_time = Time.time;
        }

    }

    public void complete_evel()
    {
        //   Debug.Log("hit  !!" + 5555);

        no_pause = true;
        level_com.SetActive(true);
        stop_time();
       
    }

    public void stop_time()
    {
        //Debug.Log("h7");
        stop_time_p = true;
        //Debug.Log("h8"+ stop_time_p);
    }

    public void start_time_fun()
    {
        start_time_num = true;
    }

    public void increase_score_bullet()
    {
    //    Debug.Log("h8");
        score_txt.text = (int.Parse(score_txt.text)+50).ToString();
        //Debug.Log("h8"+ stop_time_p);
    }

    public void increase_score_enemy()
    {
    //    Debug.Log("h9");
        score_txt.text = (int.Parse(score_txt.text) + 100).ToString();
            //Debug.Log("h8"+ stop_time_p);
    }


    void pause()
    {
      //  Debug.Log("hit  !!" + 147);

        pause_mune.SetActive(true);
        f_p.enabled = false;
        p_m.enabled = false;
        s_p.enabled = false;
        stop_bullet(s_p.get_bull_list());
        
        if (enemy1 != null && enemy1.activeInHierarchy)
        {
            s_e1.enabled = false;
        }
        if (enemy2 != null && enemy2.activeInHierarchy)
        {

            s_e2.enabled = false;
        }
        if (enemy3 != null && enemy3.activeInHierarchy)
        {

            s_e3.enabled = false;
            a_m.enabled = false;
        }

        //diffecalty 2
        if (!dif1)
        {
            if (enemy4 != null && enemy4.activeInHierarchy)
            {
                s_e4.enabled = false;
            }
            if (enemy5 != null && enemy5.activeInHierarchy)
            {
                s_e5.enabled = false;
                a_m2.enabled = false;
            }


        }
        //m_f_bullet.enabled = false;

        stop_bull_enemy();

        m_bull_enemy.enabled = false;
        audio.pause_all();
    }

    public void resume()
    {
        pause_mune.SetActive(false);
        
        p_m.enabled = true;
        s_p.enabled = true;
        play_bullet(s_p.get_bull_list());
        if (enemy1 != null && enemy1.activeInHierarchy)
        {
            s_e1.enabled = true;
        }
        if (enemy2 != null && enemy2.activeInHierarchy)
        {
            s_e2.enabled = true;
        }
        if (enemy3 != null && enemy3.activeInHierarchy)
        {
            s_e3.enabled = true;
            a_m.enabled = true;
        }
        if (!dif1)
        {

            if (enemy4 != null && enemy4.activeInHierarchy)
            {
                s_e4.enabled = true;
                a_m2.enabled = true;
            }
            if (enemy5 != null && enemy5.activeInHierarchy)
            {
                s_e5.enabled = true;
                
            }
        }

        play_bull_enemy();
        
        f_p.enabled = true;
        //  m_f_bullet.enabled = true;
        m_bull_enemy.enabled = true;
        audio.resume_all();
    }


    void stop_bullet(List<GameObject> all_bull)
    {

        if (all_bull != null)
        {
            foreach (GameObject g in all_bull)
            {
                if (g != null)
                {
                    moveforward m = g.GetComponent<moveforward>();
                    m.enabled = false;
                }
            }


        }
    }



    void play_bullet(List<GameObject> all_bull)
    {
        //Debug.Log("hit  !!" + 5588);

        if (all_bull != null)
        {
            foreach (GameObject g in all_bull)
            {
                if (g != null)
                {

                    moveforward m = g.GetComponent<moveforward>();
                    m.enabled = true;
                }
            }
        }
    }



    void stop_bull_enemy()
    {
        if (enemy1 != null && enemy1.activeInHierarchy)
        {

            // Debug.Log("s_e");    
            List<GameObject> all_bull = new List<GameObject>();
            all_bull = s_e1.get_bull_list();

            if (all_bull != null)
            {

                foreach (GameObject g in all_bull)
                {
                    if (g != null)
                    {

                        move m = g.GetComponent<move>();
                        m.enabled = false;
                    }
                }

            }
        }


        if (enemy2 != null && enemy2.activeInHierarchy)
        {

            List<GameObject> all_bull2 = new List<GameObject>();
            all_bull2 = s_e2.get_bull_list();


            if (all_bull2 != null)
            {

                foreach (GameObject g in all_bull2)
                {
                    if (g != null)
                    {

                        move m = g.GetComponent<move>();
                        m.enabled = false;
                    }
                }

            }


        }

        if (enemy3 != null && enemy3.activeInHierarchy)
        {

            List<GameObject> all_bull3 = new List<GameObject>();
            all_bull3 = s_e3.get_bull_list();
            //Debug.Log("h3");

            if (all_bull3 != null)
            {

                foreach (GameObject g in all_bull3)
                {
                    if (g != null)
                    {

                        move m = g.GetComponent<move>();
                        m.enabled = false;
                    }
                }

            }
        }

        //diffecalty 2
        if (!dif1)
        {


            if (enemy4 != null && enemy4.activeInHierarchy)
            {

                List<GameObject> all_bull4 = new List<GameObject>();
                all_bull4 = s_e4.get_bull_list();
                //Debug.Log("h3");

                if (all_bull4 != null)
                {

                    foreach (GameObject g in all_bull4)
                    {
                        if (g != null)
                        {

                            move m = g.GetComponent<move>();
                            m.enabled = false;
                        }
                    }

                }
            }



            if (enemy5 != null && enemy5.activeInHierarchy)
            {

                List<GameObject> all_bull5 = new List<GameObject>();
                all_bull5 = s_e5.get_bull_list();
                //Debug.Log("h3");

                if (all_bull5 != null)
                {

                    foreach (GameObject g in all_bull5)
                    {
                        if (g != null)
                        {

                            move m = g.GetComponent<move>();
                            m.enabled = false;
                        }
                    }

                }
            }




        }
    }


    void play_bull_enemy()
    {

        if (enemy1 != null && enemy1.activeInHierarchy)
        {
            List<GameObject> all_bull = new List<GameObject>();
            all_bull = s_e1.get_bull_list();

            if (all_bull != null)
            {

                foreach (GameObject g in all_bull)
                {
                    if (g != null)
                    {

                        move m = g.GetComponent<move>();
                        m.enabled = true;
                    }
                }

            }

        }
        if (enemy2 != null && enemy2.activeInHierarchy)
        {

            List<GameObject> all_bull2 = new List<GameObject>();
            all_bull2 = s_e2.get_bull_list();

            if (all_bull2 != null)
            {

                foreach (GameObject g in all_bull2)
                {
                    if (g != null)
                    {

                        move m = g.GetComponent<move>();
                        m.enabled = true;
                    }
                }

            }


        }

        if (enemy3 != null && enemy3.activeInHierarchy)
        {

            List<GameObject> all_bull3 = new List<GameObject>();
        all_bull3 = s_e3.get_bull_list();
        //Debug.Log("h3");
        
        
        if (all_bull3 != null)
        {

                foreach (GameObject g in all_bull3)
                {
                    if (g != null)
                    {

                        move m = g.GetComponent<move>();
                        m.enabled = true;
                    }
                }
            }

        }



        if (!dif1)
        {
            if (enemy4 != null && enemy4.activeInHierarchy)
            {

                List<GameObject> all_bull4 = new List<GameObject>();
                all_bull4 = s_e4.get_bull_list();
                //Debug.Log("h3");


                if (all_bull4 != null)
                {

                    foreach (GameObject g in all_bull4)
                    {
                        if (g != null)
                        {

                            move m = g.GetComponent<move>();
                            m.enabled = true;
                        }
                    }
                }

            }



            if (enemy5 != null && enemy5.activeInHierarchy)
            {

                List<GameObject> all_bull5 = new List<GameObject>();
                all_bull5 = s_e5.get_bull_list();
                //Debug.Log("h3");


                if (all_bull5 != null)
                {

                    foreach (GameObject g in all_bull5)
                    {
                        if (g != null)
                        {

                            move m = g.GetComponent<move>();
                            m.enabled = true;
                        }
                    }
                }

            }




        }




        }
}
