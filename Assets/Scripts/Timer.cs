using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Variables
    //Timer to start at 60 secs
    public float oxigenTime = 60;

    [SerializeField] Text teleportText;
    public Text timeText;
    public Slider timeSlider;

    [SerializeField] bool startTimer;
    [SerializeField] bool stopTimer;
    [SerializeField] bool resetTimer;
    [SerializeField] bool isAlive;

    public Movement movement;

    [SerializeField] Transform player;
    [SerializeField] Transform respawnPoint;

    private void Start()
    {
        teleportText.enabled = false;
        startTimer = true;
        isAlive = true;
        stopTimer = false;
        resetTimer = false;
        timeSlider.maxValue = oxigenTime;
        timeSlider.value = oxigenTime;
    }


    // Update is called once per frame
    void Update()
    {
        if (isAlive == true && startTimer == true)
        {
            //CountDown();

            float time = oxigenTime - Time.time;

            int seconds = Mathf.FloorToInt(time % 60);

            string textTime = string.Format("{00}", seconds);

            if (time <= 0)
            {
                startTimer = false;
                stopTimer = true;
                isAlive = false;

                if (isAlive == false)
                {
                    movement.canMove = false;
                    teleportText.enabled = true;
                }
            }

            if (stopTimer == false)
            {
                timeText.text = textTime;
                timeSlider.value = time;
            }
        }

        if(teleportText.enabled == true && Input.GetKeyDown(KeyCode.E))
        {
            resetTimer = true;
            teleportText.enabled = false;
            isAlive = true;
            player.transform.position = respawnPoint.transform.position;
            movement.canMove = true;
        }

    }


    /*void CountDown()
    {
        float time = oxigenTime - Time.time;

        int seconds = Mathf.FloorToInt(time % 60);

        string textTime = string.Format("{00}", seconds);

        if (time <= 0)
        {
            stopTimer = true;
            isAlive = false;

            if(isAlive == false)
            {
                movement.canMove = false;
                teleportText.enabled = true;
            }
        }

        if (stopTimer == false)
        {
            timeText.text = textTime;
            timeSlider.value = time;
        }
    }
    */
}
