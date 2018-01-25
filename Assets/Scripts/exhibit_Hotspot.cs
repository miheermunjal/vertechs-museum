using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exhibit_Hotspot : MonoBehaviour {

    public delegate void HotspotEntered();
    public static event HotspotEntered OnEntered;
    public string hotspotTag;
    private AudioSource audioSource;

    public delegate void HotspotExited();
    public static event HotspotExited OnExited;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entering hitzone");
        var audioObject = GameObject.FindWithTag(hotspotTag);
        audioSource = audioObject.GetComponent<AudioSource>();
        audioSource.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exiting cube");
        if (OnExited != null)
        {
            OnExited();
        }
    }
}