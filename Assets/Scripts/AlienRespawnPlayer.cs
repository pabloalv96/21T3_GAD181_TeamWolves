using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienRespawnPlayer : MonoBehaviour
{
    public Transform player;
    public Transform respawnPoint;
    public Timer timer;
    public Slots slot;
    public Inventory inventory;
    public bool droponCollide = false;

        // Start is called before the first frame update
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        player.transform.position = respawnPoint.transform.position;
        
        if (other.CompareTag("Player"))
        {
            Debug.Log("has collision occured");
            droponCollide = true;
        }
    }
 
}
