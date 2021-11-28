using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienRespawnPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    public Timer timer;
    public Slots slot;
    public Inventory inventory;
    // Start is called before the first frame update
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.transform.position = respawnPoint.transform.position;
        
    }
 
}
