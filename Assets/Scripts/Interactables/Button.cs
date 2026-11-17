using UnityEngine;

public class PressButton : MonoBehaviour
{
    public bool wasPressed = false;
    public float cooldown = 0.5f;

    private float lastPressTime = -10f;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger hit by: " + other.name + " tag: " + other.tag);

        if (!other.CompareTag("Player")) return;
        if (Time.time - lastPressTime < cooldown) return;
        lastPressTime = Time.time;

        wasPressed = !wasPressed;
        Debug.Log(wasPressed ? "Button pressed" : "Button was unpressed");
    }
}