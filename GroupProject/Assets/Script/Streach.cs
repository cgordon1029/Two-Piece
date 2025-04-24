using UnityEngine;

public class Streach : MonoBehaviour
{
    void Start()
    {
        ResizeQuad();
    }

    void ResizeQuad()
    {
        Camera cam = Camera.main;
        if (cam == null)
        {
            Debug.LogError("Main Camera not found!");
            return;
        }

        // Get screen dimensions in world space
        float height = 2f * cam.orthographicSize;
        float width = height * cam.aspect;

        // Apply scaling to fit the screen
        transform.localScale = new Vector3(width, height, 1);
    }
}
