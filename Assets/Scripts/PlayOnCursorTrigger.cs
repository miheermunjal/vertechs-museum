using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnCursorTrigger : MonoBehaviour {

    public string AudioClip;
    private AudioSource audioSource;
    
    private void Start()
    {
        var audioObject = GameObject.FindWithTag("ExhibitAudio");
        if (audioObject != null)
        {
            audioSource = audioObject.GetComponent<AudioSource>();
            audioSource.clip = Resources.Load<AudioClip>(AudioClip);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Cursor")
        {
            Debug.Log("entering hitzone");
            if (audioSource != null && !audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        /*if (other.gameObject.name == "Cursor")
        {

            Debug.Log("exiting cube");
            if (audioSource != null && audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }*/
    }
}