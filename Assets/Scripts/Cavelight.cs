using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cavelight : MonoBehaviour
{
    public GameObject pointLight;

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
        if (other.gameObject.tag == "Cave")
        {
            pointLight.SetActive(true);
        }
        else
        {
            pointLight.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Cave")
        {
            pointLight.SetActive(false);
        }
        else
        {
            pointLight.SetActive(true);
        }
    }
}
