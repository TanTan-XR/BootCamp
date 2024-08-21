using UnityEngine;
using System.Collections;

public class ParticleSystemController : MonoBehaviour
{
    public ParticleSystem particleSystem; // Assign your Particle System in the Inspector
    public float startDelay = 1.0f; // Delay before starting the particle system
    public float stopDelay = 5.0f;  // Duration to wait before stopping the particle system

    private void Start()
    {
        if (particleSystem != null)
        {
            // Start the coroutine for starting and stopping the particle system
            StartCoroutine(ControlParticleSystem());
        }
        else
        {
            Debug.LogWarning("ParticleSystem is not assigned.");
        }
    }

    private IEnumerator ControlParticleSystem()
    {
        // Wait for the specified start delay
        yield return new WaitForSeconds(startDelay);

        // Start the particle system
        particleSystem.Play();
        Debug.Log("Particle system started.");

        // Wait for the specified stop delay
        yield return new WaitForSeconds(stopDelay);

        // Stop the particle system
        particleSystem.Stop();
        Debug.Log("Particle system stopped.");
    }
}
