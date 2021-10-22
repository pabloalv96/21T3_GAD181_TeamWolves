using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    public Transform lookAt; //player transform
    public float boundX = 0.15f;
    public float boundY = 0.05f;


    private void LateUpdate() //the player movement completed before the assessment of camera movmement within the bounds area
    {
        Vector3 delta = Vector3.zero; //initialises the position of the camera at 0

        // this measures the distance between the player X and the centre of the camera X 
        float deltaX = lookAt.position.x - transform.position.x; //deltaX is the difference between the 2 X points
        // this determines left or right, if deltax is greater than bound x then the camera is on the right, if delta x is less then boundX camera is on the left
        if (deltaX > boundX || deltaX < -boundX)
        {
            if (transform.position.x < lookAt.position.x)// this means player is on the right and camera is on the left. If player continues to go right then we need to add to the camera x point
            {
                delta.x = deltaX - boundX;
            }
            else
            {
                delta.x = deltaX + boundX;
            }
        }
        float deltaY = lookAt.position.y - transform.position.y;
        if (deltaY > boundY || deltaY < -boundY)
        {
            if (transform.position.y < lookAt.position.y)
            {
                delta.y = deltaY - boundY;
            }
            else
            {
                delta.y = deltaY + boundY;
            }
        }
        transform.position += new Vector3(delta.x, delta.y, 0);
    }
}
