using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sustain : MonoBehaviour
{
    // Static reference to the instance of the Sustain class
    private static Sustain instance;

    // Public property to access the instance
    public static Sustain Instance
    {
        get { return instance; }
    }

    // Awake is called when the script instance is being loaded
    void Awake()
    {
        // Check if an instance already exists
        if (instance == null)
        {
            // If not, set the instance to this
            instance = this;
            // Don't destroy this object when loading new scenes
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // If an instance already exists and it's not this one, destroy this instance
            Destroy(gameObject);
        }
    }
}