using UnityEngine;

public class RotateOnTriggerStart : MonoBehaviour
{
    public Vector3 rotationAxis = Vector3.up; // Axis of rotation
    public float rotationSpeed = 45f; // Speed of rotation in degrees per second
    private bool shouldRotate = false; // Initially set to false

    void OnTriggerEnter(Collider other)
    {
        // Start rotation upon entering the trigger
        shouldRotate = true;
    }

    void Update()
    {
        if (shouldRotate)
        {
            transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime);
        }
    }

    // Optional: Method to manually start the rotation
    public void StartRotation()
    {
        shouldRotate = true;
    }
}
