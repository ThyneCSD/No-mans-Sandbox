using UnityEngine;

public class Button : MonoBehaviour
{
    private bool wasPressed = false;
    //Deze comment zet ik hier neer zodat het lijkt alsof ik oprecht comments gebruik.
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
