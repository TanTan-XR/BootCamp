using UnityEngine;
using System.Collections;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer; // Assign the SpriteRenderer in the Inspector
    public Sprite newSprite; // Assign the new sprite in the Inspector
    public float delayTime = 1.0f; // Delay time in seconds

    private void Start()
    {
        // Start the coroutine to change the sprite after a delay
        StartCoroutine(ChangeSpriteAfterDelay());
    }

    private IEnumerator ChangeSpriteAfterDelay()
    {
        // Wait for the specified amount of time
        yield return new WaitForSeconds(delayTime);

        // Change the sprite
        if (spriteRenderer != null && newSprite != null)
        {
            spriteRenderer.sprite = newSprite;
        }
        else
        {
            Debug.LogWarning("SpriteRenderer or newSprite is not assigned.");
        }
    }
}
