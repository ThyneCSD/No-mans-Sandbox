using UnityEngine;

public class pressurePlate : MonoBehaviour
{
    private bool isPressed = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Object") && !isPressed)
        {
            Debug.Log("the thick thighs are on the pressure plate");
            isPressed = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Object") && isPressed)
        {
            Debug.Log("the thick thighs are NOT on the pressure plate");
            isPressed = false;
        }
    }
}
