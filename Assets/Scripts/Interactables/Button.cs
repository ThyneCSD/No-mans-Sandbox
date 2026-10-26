using UnityEngine;

public class Button : MonoBehaviour
{
    public bool wasPressed = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && !wasPressed)
        {
            Debug.Log("Button pressed!");
            wasPressed = true;
        } else if (collision.gameObject.CompareTag("Player") && wasPressed)
        {
            Debug.Log("Button was UNpressed");
            wasPressed = false;
        }
    }
}
