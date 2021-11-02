using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Variables
    //Timer to start at 60 secs
    public float oxigenTime = 60;
    public float initialTimeValue = 60;

    [SerializeField] Text teleportText;
    public Text timeText;
    public Slider timeSlider;

    [SerializeField] public bool startTimer;
    [SerializeField] public bool stopTimer;
    [SerializeField] public bool resetTimer;
    [SerializeField] public bool isAlive;

    //public PlayerMovement movement;
    public Movement movement;

    [SerializeField] Transform player;
    [SerializeField] Transform respawnPoint;

    private void Start()
    {
        teleportText.enabled = false;
        isAlive = true;
        startTimer = true;
        stopTimer = false;
        resetTimer = false;
        timeSlider.maxValue = oxigenTime;
        timeSlider.value = oxigenTime;
    }


    // Update is called once per frame
    void Update()
    {
        int seconds = Mathf.FloorToInt(oxigenTime % 60);

        string textTime = string.Format("{00}", seconds);


        if (isAlive && startTimer)
        {
            //CountDown
            oxigenTime -= Time.deltaTime;

            if (oxigenTime <= 0)
            {
                oxigenTime = 0;
                startTimer = false;
                stopTimer = true;
                isAlive = false;
            }

            if (stopTimer == false)
            {
                timeText.text = textTime;
                timeSlider.value = oxigenTime;
            } else
            {
                timeSlider.value = 0;
            }
        }

        if (!isAlive)
        {
            movement.canMove = false;
            teleportText.enabled = true;
        }


        if (teleportText.enabled == true && Input.GetKeyDown(KeyCode.E))
        {
            
            Debug.Log("You pressed E");
            isAlive = true;
            movement.canMove = true;
            resetTimer = true;
            teleportText.enabled = false;
            player.transform.position = respawnPoint.transform.position;
        }

        if(resetTimer)
        {
            oxigenTime = initialTimeValue;

            timeText.text = textTime;
            timeSlider.value = oxigenTime;

            startTimer = true;
            stopTimer = false;
            resetTimer = false;

        }

    }

}
