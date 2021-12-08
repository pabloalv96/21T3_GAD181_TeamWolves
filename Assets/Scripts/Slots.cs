using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Slots : MonoBehaviour
{
    private Inventory inventory;
    public int i;
    public Timer timer;
    public Win win;
    public int winCounter=0;
    public AlienRespawnPlayer collisionDrop;
   // public bool test = false;

    private void Start()
    {
        timer = FindObjectOfType<Timer>();
        collisionDrop = FindObjectOfType<AlienRespawnPlayer>();
        //collisionDrop = GameObject.FindGameObjectWithTag("Respawn").GetComponent<AlienRespawnPlayer>();
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void Update()
    {
       if (collisionDrop.droponCollide)
        {
           Debug.Log("Alien collision");
           DropItem();
           collisionDrop.droponCollide = false;
        }

        if (timer.oxigenTime <= 0 && Input.GetKeyDown(KeyCode.E))
        {
            DropItem();                
        }
                
        if (Input.GetKeyDown(KeyCode.E) && win.textEnabled == true)
        {
            DestroyItem();
        }

        if (transform.childCount <= 0)
        {
            inventory.isFull[i] = false;
        }
    }

    public void DropItem ()
    {
        foreach (Transform child in transform)
        {
            child.GetComponent<Spawn>().SpawnDroppedItem();
            GameObject.Destroy(child.gameObject); 
        }
    }

    public void DestroyItem()
    {
        foreach (Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);

            if(inventory.isFull[0] == true || inventory.isFull[1] == true)
            {
                winCounter += 1;
            }
            

            if(inventory.isFull[0] == true && inventory.isFull[1] == true)
            {
                winCounter += 2;
            }

            if (winCounter >= 2)
            {
                SceneManager.LoadScene("End Screen");
            }
        }
    }

    
}
