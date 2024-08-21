using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    private void OnEnable()
    {
        Invoke("DestroySelf", 10f); // Calls DestroySelf after 5 seconds
    }

    private void DestroySelf()
    {
        Destroy(gameObject); // Destroys the GameObject this script is attached to
    }

    private void OnDisable()
    {
        CancelInvoke(); // Ensure to cancel if the object is disabled before 5 seconds
    }
}
