using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    private Vector3 moveDelta;
    private RaycastHit2D hit;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {
        //For X axis a = -1,  d = 1, For Y Axis W = 1 S = -1
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        //Debug.Log(x);
        //Debug.Log(y);

        //Reset MoveDelta
        moveDelta = new Vector3(x, y, 0);

        //Swap sprite direction, whether you are going right or left
       // if (moveDelta.x > 0)
       //     transform.localScale = Vector3.one;//As all the vectors will be one and this is statice we can use one
        //else if (moveDelta.x < 0)
        //    transform.localScale = new Vector3(-1, 1, 1);// As we need to use -1 we cannot use "one" in this instance

        //We cast a box on Y to see if we can move there it will look for any information on the LayerMasks if not it will move the player along the Y
        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(0, moveDelta.y), Mathf.Abs(moveDelta.y * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));
        if (hit.collider == null)
        {
            //Make this player move along Y because we are splitting the X and Y we now do the 3 floats
            transform.Translate(0, moveDelta.y * Time.deltaTime, 0);
        }
        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(moveDelta.x, 0), Mathf.Abs(moveDelta.x * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));
        if (hit.collider == null)
        {
            //Make this player move along Y because we are splitting the X and Y we now do the 3 floats
            transform.Translate(moveDelta.x * Time.deltaTime, 0, 0);
            //in unity settings we need to stop player hitting itself as they are on the actor layer
            // Change the settings physics 2D turn of Query starts in collider
        }
    }
}
