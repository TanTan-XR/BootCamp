using UnityEngine;
using System.Collections;

public class ActivateOnSelection : MonoBehaviour
{
    public GameObject[] objectsToActivate; // Assign the parent and child GameObjects to activate
    public float activationDelay = 2.0f; // Time in seconds to wait before activation

    // This method should be called when the object is selected
    public void OnSelected()
    {
        StartCoroutine(ActivateAfterDelay());
    }

    private IEnumerator ActivateAfterDelay()
    {
        // Wait for the specified delay time
        yield return new WaitForSeconds(activationDelay);

        // Activate each GameObject in the array
        foreach (GameObject obj in objectsToActivate)
        {
            if (obj != null)
            {
                obj.SetActive(true);
            }
        }

        Debug.Log("Selection event occurred, objects activated after delay.");
    }
}
