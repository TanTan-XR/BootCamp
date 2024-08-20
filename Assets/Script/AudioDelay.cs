using System.Collections;
using UnityEngine;

public class AudioDelay : MonoBehaviour
{
    public AudioSource audioSource; // Assign this in the inspector
    public float delay = 2f; // Set the delay time in seconds

    private void Start()
    {
        // Start the coroutine to delay the audio
        StartCoroutine(PlayAudioAfterDelay());
    }

    private IEnumerator PlayAudioAfterDelay()
    {
        // Wait for the specified delay time
        yield return new WaitForSeconds(delay);

        // Play the audio source
        audioSource.Play();
    }
}
