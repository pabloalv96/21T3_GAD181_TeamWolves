using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienRespawnPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.transform.position = respawnPoint.transform.position;
    }
}
