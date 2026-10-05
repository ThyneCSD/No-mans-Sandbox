using UnityEngine;

public class Glass : MonoBehaviour
{
    private BoxCollider boxCollider;
    private Renderer cubeRenderer;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
        cubeRenderer = GetComponent<Renderer>();
    }

    public void PressButton()
    {
        if (boxCollider != null)
        {
            boxCollider.isTrigger = false;
        }

        if (cubeRenderer != null)
        {
            cubeRenderer.material.color = Color.green;
        }
    }
}