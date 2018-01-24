using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitboxcollision : MonoBehaviour {

    public const int exhibitCount = 1;
    private GameController gameController;
    AudioSource audioSource = null;
    AudioClip enterZoneSound = null;
    AudioClip exitZoneSound = null;

    // Use this for initialization
    void Start () {

         // Add an AudioSource component and set up some defaults
         audioSource = gameObject.AddComponent<AudioSource>();
         audioSource.playOnAwake = false;
         audioSource.spatialize = true;
         audioSource.spatialBlend = 1.0f;
         audioSource.dopplerLevel = 0.1f;
         audioSource.rolloffMode = AudioRolloffMode.Custom;

         // Load the sounds from the Resources folder
         enterZoneSound = Resources.Load<AudioClip>("female voices");
         exitZoneSound = Resources.Load<AudioClip>("chimes");

         //find Game Object per each collision
         GameObject gameControllerObject = GameObject.FindWithTag("GameController");
         if (gameControllerObject != null)
         {
                gameController = gameControllerObject.GetComponent<GameController>();
         }
         if (gameController == null)
         {
             Debug.Log("Cannot find 'GameController' script");
         }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "EXHIBIT")
        {
            //Destroy(col.gameObject);
            gameController.addExhibit();
            audioSource.clip = enterZoneSound;
            audioSource.volume = 0.3f;
            audioSource.Play();
        }

    }
}