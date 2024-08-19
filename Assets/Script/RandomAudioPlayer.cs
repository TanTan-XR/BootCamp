using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;


[RequireComponent(typeof(AudioSource))] //this will ensure hwo it wont run without the audiosource
public class RandomAudioPlayer : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();  //it will return if it's on the same game object
    }

    public void PlayOneShot(AudioClipList list)
    {
        int index = Random.Range(0, list.clips.Count); //this will give me 9 digits, but between 0-8 if we have 0,9, ubt if we have list.clip.list it will countr thr number of list 
        AudioClip clip = list.clips[index];

        audioSource.clip = clip; //telling which clip to paly
        audioSource.Play(); //this is how it playes or

        /*
         * audioSource.PlayOneShot(clip);
         */
    }

}
