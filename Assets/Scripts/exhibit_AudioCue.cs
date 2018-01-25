using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exhibit1_AudioCue : MonoBehaviour {

    public AudioClip[] clips;
    private AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        exhibit_Hotspot.OnEntered += OnHotspotEnter;
    }

    private void OnDisable()
    {
        exhibit_Hotspot.OnEntered -= OnHotspotEnter;
    }

    private void OnHotspotEnter()
    {
        int randomNum = Random.Range(0, clips.Length);
        audioSource.clip = clips[randomNum];
        audioSource.Play();
    }
}