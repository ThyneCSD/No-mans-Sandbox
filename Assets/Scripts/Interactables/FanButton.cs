using UnityEngine;

public class FanButton : MonoBehaviour
{
    private bool wasPressed = false;
    public Fan fan;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && !wasPressed)
        {
            Debug.Log("Button pressed!");
            wasPressed = true;
            fan.isPowerOn = true;
        } else if (collision.gameObject.CompareTag("Player") && wasPressed)
        {
            Debug.Log("Button was UNpressed");
            wasPressed = false;
            fan.isPowerOn = false;
        }
    }
}
