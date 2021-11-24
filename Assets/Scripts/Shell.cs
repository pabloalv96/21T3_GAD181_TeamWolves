using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{

    private Timer myShell;
    [SerializeField] private GameObject objectToBeSpawned;
    [SerializeField] int numberofItems;
    [SerializeField] private Transform spawnedLocation;



    // Start is called before the first frame update
    void Start()
    {
        myShell = FindObjectOfType<Timer>();
        Debug.Log(myShell.oxigenTime);
        // for (int i = 0; i >= numberofItems; i++)
        {

        }
    }
    private void Update()
    {

        //for (int i = 0; i < numberofItems; i++)
            
        if (myShell.oxigenTime <1)
        {
           Instantiate(objectToBeSpawned, spawnedLocation);
        }
    }
}
