using UnityEngine;

public class HorizontalRotator : MonoBehaviour
{
    public float rotationSpeed = 90f; // Rotation speed in degrees per second

    void Update()
    {
        // Calculate the amount of rotation for this frame
        float rotationAmount = rotationSpeed * Time.deltaTime;

        // Rotate the GameObject around its Y-axis
        transform.Rotate(0, rotationAmount, 0);
    }
}

