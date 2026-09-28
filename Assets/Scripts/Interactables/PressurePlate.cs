using UnityEngine;

public class pressurePlate : MonoBehaviour
{
    private bool isPressed = false;
    public Key key;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Object") && !isPressed)
        {
            Debug.Log("Pressure plate pressed!");
            isPressed = true;
            key.openDoor = true;
        }
    }

    //private void OnCollisionExit(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Object") && isPressed)
    //    {
    //        isPressed = false;
    //        Debug.Log("Pressure plate released!");
    //    }
    //}
}
