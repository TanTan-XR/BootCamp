using UnityEngine;

public class DelayedAppearance : MonoBehaviour
{
    public float delay = 5f; // Delay in seconds

    private void Start()
    {
        gameObject.SetActive(false); // Initially deactivate the sprite
        Invoke("ShowSprite", delay); // Invoke ShowSprite after the delay
    }

    private void ShowSprite()
    {
        gameObject.SetActive(true); // Activate the sprite
    }
}
