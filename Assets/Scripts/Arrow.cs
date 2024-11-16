using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public Transform camPos;
    public Transform golfPos;

    private Vector3 directionToBall;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate a vector that describes the change in position between the camera and the ball
        directionToBall = golfPos.position - camPos.position;

        //Debug.Log(directionToBall);

        // Set the Y value to 0 so it will always be the same height as the ball
        directionToBall.y = 0;


        // Normalize the vector (Set it's length to 1)
        directionToBall.Normalize();
        // Scale the vector to the length needed so the arrow isn't too close or too far away
        directionToBall *= 1.75f;

        // Set the arrows position to the gold balls position + the new vector
        transform.position = golfPos.position + directionToBall;

        // Calculate the rotation of the arrow based on the vector from above
        float angle = Mathf.Atan2(directionToBall.z, directionToBall.x) * Mathf.Rad2Deg;

        // Set the rotation of the arrow based on the angle calculated above
        transform.rotation = Quaternion.Euler(90f, -angle, 0f);

        //Debug.Log(angle);
    }

    public Vector3 getHitDir()
    {
        return directionToBall.normalized;
    }
}
