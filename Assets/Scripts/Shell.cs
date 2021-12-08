using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{

    private Timer myShell;
    [SerializeField] private GameObject objectToBeSpawned;
    //[SerializeField] private GameObject crateToBeSpawned;
    public bool isSpawned = false;
    public AudioSource source;
    public AudioClip clip;
    //public AlienRespawnPlayer crateSpawn;


    // Start is called before the first frame update
    void Start()
    {
        myShell = FindObjectOfType<Timer>();
        Debug.Log(myShell.oxigenTime);
        
    }
    private void Update()
    {
            if (myShell.oxigenTime <= 0)
            {
                if (!isSpawned)
                {
                    Instantiate(objectToBeSpawned, transform.position, Quaternion.identity);
                    isSpawned = true;
                }
            }
       /* if (crateSpawn.droponCollide == true)
        {
           Instantiate(crateToBeSpawned, transform.position, Quaternion.identity);
            crateSpawn.droponCollide = false;
            Debug.Log(crateSpawn.droponCollide);
            Debug.Log("Crate Spawned");
        }*/
    }
}
