using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    //Variables for score and final score
    public static int score = 0;

    //Variables for score texts
    public Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        //starts at 0 again for new score record
        if(score > 0)
        {
            score = 0;
        }
    }

    // Score updates 
    void Update()
    {
        ScoreText.text = " Score: " + Mathf.Round(score);
    }

}
