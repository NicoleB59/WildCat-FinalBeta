using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeLeft : MonoBehaviour
{
    //Current timer and Start timer
    float currentT = 0;
    float startT = 30;

    //Adding a reference to timerText
    public Text TimerText;

    // Start is called before the first frame update
    void Start()
    {
        currentT = startT;
    }

    // Update is called once per frame
    void Update()
    {
        currentT -= 1 * Time.deltaTime;
        TimerText.text = "Timer: " + currentT.ToString("0");

        //When timer is less or equal to 0, timer will stop at 0.
        if(currentT <= 0)
        {
            currentT = 0;
            SceneManager.LoadScene("Win");
        }
    }


}
