using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public Text repairText;
    public bool textEnabled;
    public int systemCounter = 0;
    //public PickUps crateToDestoy;
    private Inventory inventory;

    // Start is called before the first frame update
    void Start()
    {
        repairText.enabled = false;
        textEnabled = false;
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
       /*if(Input.GetKeyDown(KeyCode.E))
        {
            DestroyItem();
            //Destroy(crateToDestoy.UICrate);
        } */
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Repair the system");
            repairText.enabled = true;
            textEnabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            repairText.enabled = false;
            textEnabled = false;
        }
    }

    public void DestroyItem()
    {
        foreach (Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }
}
