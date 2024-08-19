using UnityEngine;
using UnityEngine.UI;

public class ColorChangeOnTrigger : MonoBehaviour
{
    // Reference to the UI Panel's Image component
    public Image panelImage;

    // Field to assign the new color in the Unity Editor
    public Color newColor = Color.green;


    private void OnTriggerEnter(Collider other)
    {
        // Check if the triggering object has the valid tag
 
        {
            ChangePanelColor(newColor);
        }
    }

    // Method to change the panel's color
    void ChangePanelColor(Color color)
    {
        if (panelImage != null)
        {
            panelImage.color = color;
        }
        else
        {
            Debug.LogError("Panel Image is not assigned.");
        }
    }
}
