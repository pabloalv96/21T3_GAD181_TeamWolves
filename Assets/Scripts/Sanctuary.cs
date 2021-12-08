using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sanctuary : MonoBehaviour
{
    public Timer timer;
    private Shell resetSpawner;
    
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
        resetSpawner = FindObjectOfType<Shell>();
        Debug.Log(resetSpawner.isSpawned);
        resetSpawner.GetComponent<Shell>().isSpawned = false;
        
                        
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("You are in sanctuary");            
            timer.startTimer = false;
            timer.stopTimer = true;
            timer.resetTimer = true;            
        } else
        {
            //timer.startTimer = true;
            timer.stopTimer = false;
            timer.resetTimer = false;
        }
    }

   private void OnTriggerStay2D(Collider2D other)
   {
        if (other.gameObject.tag == "Player")
        {
            timer.startTimer = false;
            timer.stopTimer = true;
           //timer.resetTimer = true;
        }
        else
        {
            //timer.startTimer = true;
            timer.stopTimer = false;
            timer.resetTimer = false;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            timer.startTimer = true;
            timer.stopTimer = false;
            timer.resetTimer = true;
        }
        else
        {
            
            timer.startTimer = false;
            timer.stopTimer = true;
            timer.resetTimer = true;
        }
    }
}
