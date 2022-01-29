using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mange_bottons : MonoBehaviour
{
  public void click_exit()
    {
        SceneManager.LoadScene("start__scence");
    }
    public void click_restart()
    {
        SceneManager.LoadScene("game");
    }
}
