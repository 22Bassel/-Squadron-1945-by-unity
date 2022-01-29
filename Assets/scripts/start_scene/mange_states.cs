using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mange_states : MonoBehaviour
{
   
     public void start_game()
    {
        FindObjectOfType<Audio_Manger>().stop("song");
        SceneManager.LoadScene("game");

    }

    public void quit_game()
    {

        Application.Quit();

    }

}
