using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Variables
    //Timer to start at 60 secs
    public float oxigenTime = 60;

    public Text timeText;
    public Slider timeSlider;

    private bool stopTimer;

    private void Start()
    {
        stopTimer = false;
        timeSlider.maxValue = oxigenTime;
        timeSlider.value = oxigenTime;
    }


    // Update is called once per frame
    void Update()
    {
        float time = oxigenTime - Time.time;

        int seconds = Mathf.FloorToInt(time % 60);

        string textTime = string.Format("{00}", seconds);

        if (time<=0)
        {
            stopTimer = true;
        }

        if (stopTimer == false)
        {
            timeText.text = textTime;
            timeSlider.value = time;
        }
    }

}
