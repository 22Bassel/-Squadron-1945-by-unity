using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level_loader : MonoBehaviour
{

    public Animator cross;
    bool here_right=false, here_left=false;
    float click_time;
    //private Animation c;
    void start()
    {
        click_time = Time.time;
      //  c = gameObject.GetComponent<Animation>();

    }
    // Update is called once per frame
    void Update()
    {

        if (Time.time > click_time + 1)
        {
            
            if (Input.GetKey("left"))
            {
                
                if (here_right) {  click_time = Time.time; StartCoroutine(back_right()); here_right = false; }
                else if (!here_left)
                {
                    click_time = Time.time;
                    here_left = true;
                    StartCoroutine(go_left());

                }
            }

            if (Input.GetKey("right"))
            {
                
                if (here_left) {  click_time = Time.time; StartCoroutine(back_left()); here_left = false; }
                else if (!here_right)
                {
                    click_time = Time.time;
                    here_right = true;
                    StartCoroutine(go_right());

                }
            }

        }
    }

    IEnumerator go_left()
    {
        cross.SetBool("left",true);
        yield return new WaitForSeconds(1);
        
    }

    IEnumerator back_left()
    {

        cross.SetBool("left", false);
        cross.SetBool("right", false);

        cross.SetBool("back_f_left", true);
        yield return new WaitForSeconds(1);
        cross.SetBool("back_f_left", false);

    }


    IEnumerator go_right()
    {
        cross.SetBool("right", true);
        yield return new WaitForSeconds(1);

    }

    IEnumerator back_right()
    {

        cross.SetBool("right", false);
        cross.SetBool("left", false);

        cross.SetBool("back_f_right", true);
        yield return new WaitForSeconds(1);
        cross.SetBool("back_f_right", false);

    }


}
