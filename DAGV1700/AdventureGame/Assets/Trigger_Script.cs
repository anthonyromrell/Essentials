using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material newMaterial; // Assign the new material in the Inspector

    void Start()
    {
        // Get the SpriteRenderer component
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        // Check if the SpriteRenderer and newMaterial are valid
        if (spriteRenderer != null && newMaterial != null)
        {
            // Change the material
            spriteRenderer.material = newMaterial;
        }
        else
        {
            Debug.LogWarning("SpriteRenderer or newMaterial is missing!");
        }
    }
}