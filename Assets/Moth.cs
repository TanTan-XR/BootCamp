using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moth : MonoBehaviour   
{
    public AudioClipList audioClipList;
    public AudioSource audioSource;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayRandomAudio()
    {
        var clip = audioClipList.clips[Random.Range(0, audioClipList.clips.Count - 1)];
        audioSource.clip = clip;
        audioSource.Play();
    }
}
