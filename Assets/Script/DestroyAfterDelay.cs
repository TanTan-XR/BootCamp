using UnityEngine;
using System.Collections;

public class DestroyAfterDelay : MonoBehaviour
{
    public float delay = 2.0f; // Time in seconds to wait before destroying the object

    private void Start()
    {
        // Start the coroutine to destroy the object after a delay
        StartCoroutine(DestroyAfterDelayCoroutine());
    }

    private IEnumerator DestroyAfterDelayCoroutine()
    {
        // Wait for the specified delay time
        yield return new WaitForSeconds(delay);

        // Destroy the GameObject this script is attached to
        Destroy(gameObject);

        Debug.Log("GameObject has been destroyed after a delay of " + delay + " seconds.");
    }
}
