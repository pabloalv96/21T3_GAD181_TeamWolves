using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{

    public Transform player;
    // Start is called before the first frame update
    void LateUpdate() //updates the mini map after the player has moved
    {
        Vector3 newPosition = player.position; // calls the postion = player postion
        newPosition.z = transform.position.z; // moves the player to the new y postion
        transform.position = newPosition; //resets the player postion once stopped to new postion
    }
}
