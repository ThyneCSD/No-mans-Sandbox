using System.Diagnostics;
using UnityEngine;

public class MickButton : MonoBehaviour
{
    public Glass[] glassTargets;
    public SwitchImages SwitchImages;

    private void OnTriggerEnter(Collider other)
    {
        if (glassTargets != null)
        {
            foreach (Glass glass in glassTargets)
            {
                if (glass != null)
                {
                    glass.PressButton();
                    SwitchImages.isglass = !SwitchImages.isglass;
                }
            }
        }

        Renderer btnRenderer = GetComponent<Renderer>();
        if (btnRenderer != null)
        {
            btnRenderer.material.color = Color.green;
        }
    }
}