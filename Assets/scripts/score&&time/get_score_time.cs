using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class get_score_time : MonoBehaviour
{
    public Text time_txt;
    public Text score_txt;

    public Text write;
    // Start is called before the first frame update
    void Start()
    {
        write.text = time_txt.text + "\t\t\t\t\t score : "+ score_txt.text;
    }

}
