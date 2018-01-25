using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exhibit_Hotspot : MonoBehaviour {

    public string AudioSourceTag;
    private AudioSource audioSource;
    
    private void Start()
    {
        var audioObject = GameObject.FindWithTag(AudioSourceTag);
        if (audioObject != null)
        {
            audioSource = audioObject.GetComponent<AudioSource>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entering hitzone");
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exiting cube");
        if (audioSource != null && audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}