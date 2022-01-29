using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click_sound : MonoBehaviour
{
  
    public void clicked()
    {
       // Debug.Log("clicked !!");
        FindObjectOfType<Audio_Manger>().play("click");


    }
}
