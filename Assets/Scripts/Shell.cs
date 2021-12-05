using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{

    private Timer myShell;
    [SerializeField] private GameObject objectToBeSpawned;
    public bool isSpawned = false;
    public AudioSource source;
    public AudioClip clip;


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
           // if (myShell.oxigenTime <= 22 && myShell.oxigenTime >=1)
           // {
           // source.PlayOneShot(clip);
            //}
    }
}
