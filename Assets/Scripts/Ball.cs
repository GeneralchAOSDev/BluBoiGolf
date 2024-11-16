using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    private float forceHold = 0f;
    private float timePass;
    private Rigidbody rigidBody;
    public Arrow arrRef;
    public ParticleSystem particle;
    private bool triggered;
    public AudioSource audio;
    public AudioSource bump;
    private Vector3 arrVel;
    public Transform Cam;
    public Text powText;
    static public float power = 0f;

    // Start is called before the first frame update
    void Start()
    {
        // start
        rigidBody = GetComponent<Rigidbody>();
        arrVel = GameObject.Find("Arrow").transform.localScale;
        powText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
        // check for space being pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            forceHold += 1420;
            timePass = Time.time;
            particle.Play();
            triggered = true;
            audio.Play();
            power = forceHold;
            powText.text = "Jules of Energy " + power;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            forceHold += 20;
            timePass = Time.time;
            particle.Play();
            triggered = true;
            audio.Play();
            power = forceHold;
            powText.text = "Jules of Energy " + power;
        }

        if (Time.time > timePass + 0.25f && triggered)
        {
            zoom();
        }

        Vector3 vel = rigidBody.velocity;
        if (vel.magnitude == 0)
        {
            GameObject.Find("Arrow").transform.localScale = arrVel;
            //Debug.Log("Still like calm Water");

        }
        else
        {
            GameObject.Find("Arrow").transform.localScale = new Vector3(0, 0, 0);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        bump.Play();
    }
    private void zoom()
    {
        rigidBody.AddForce(arrRef.getHitDir() * forceHold);
        forceHold = 0f;
        triggered = false;
        Score.UpdateScore();
        power = 0;
        powText.text = "" ;
    }
   
}


