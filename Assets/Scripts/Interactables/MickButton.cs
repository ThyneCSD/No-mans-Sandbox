using UnityEngine;

public class MickButton : MonoBehaviour
{
    // Drag all 5 of your glass/cube objects into this list in the Unity Inspector
    public Glass[] glassTargets;

    private void OnTriggerEnter(Collider other)
    {
        // Loop through all the glass objects in the list and trigger them
        if (glassTargets != null)
        {
            foreach (Glass glass in glassTargets)
            {
                if (glass != null)
                {
                    glass.PressButton();
                }
            }
        }

        // Turn the button green when touched
        Renderer btnRenderer = GetComponent<Renderer>();
        if (btnRenderer != null)
        {
            btnRenderer.material.color = Color.green;
        }
    }
}