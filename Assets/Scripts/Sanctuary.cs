using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sanctuary : MonoBehaviour
{
    public Timer timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("You are in sanctuary");
            timer.startTimer = true;
            timer.resetTimer = false;
        }
    }
}
