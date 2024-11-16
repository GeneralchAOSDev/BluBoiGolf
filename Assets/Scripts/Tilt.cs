using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt : MonoBehaviour
{
    private float startTilt;
    public static float tiltAmount;
    public void Start()
    {
        startTilt = transform.rotation.x;
    }
    private bool tilting = false;

    public float rotationSpeed = 30f;
    void Update()
    {
        float getTilt = transform.rotation.x;
        //Debug.Log(getTilt);
        if (Input.GetKey(KeyCode.A))
        {

            tiltLeft();
            tilting = true;
            tiltAmount = getTilt;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            tiltRight();
            tilting = true;
            tiltAmount = getTilt;
        }
        else
        {
            tilting = false;
            tiltAmount = 0f;
        }

        
        if(getTilt > startTilt && !tilting)
        {
            float rotationAmount = rotationSpeed * Time.deltaTime;
            Vector3 tiltAngle = new Vector3(-1f, 0f, 0f);
            transform.Rotate(tiltAngle, rotationAmount);
        }
        if (getTilt < startTilt && !tilting)
        {
            float rotationAmount = rotationSpeed * Time.deltaTime;
            Vector3 tiltAngle = new Vector3(1f, 0f, 0f);
            transform.Rotate(tiltAngle, rotationAmount);
        }
    }

    private void tiltRight()
    {
        float rotationAmount = rotationSpeed * Time.deltaTime;
        Vector3 tiltAngle = new Vector3(-1f, 0f, 0f);
        transform.Rotate(tiltAngle, rotationAmount);
    }
    private void tiltLeft()
    {
        float rotationAmount = rotationSpeed * Time.deltaTime;
        Vector3 tiltAngle = new Vector3(1f, 0f, 0f);
        transform.Rotate(tiltAngle, rotationAmount);
    }
}
