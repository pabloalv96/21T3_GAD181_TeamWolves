using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{

    private Timer myShell;
    [SerializeField] private GameObject objectToBeSpawned;
    public bool isSpawned = false;



    // Start is called before the first frame update
    void Start()
    {
        myShell = FindObjectOfType<Timer>();
        Debug.Log(myShell.oxigenTime);
                {

        }
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
    }
}
