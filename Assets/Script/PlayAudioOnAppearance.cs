using UnityEngine;

public class PlayAudioOnAppearance : MonoBehaviour
{
    private AudioSource audioSource;

    private void Awake()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        // Play the audio when the GameObject becomes active
        if (audioSource != null)
        {
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("AudioSource is not attached to the GameObject.");
        }
    }
}
