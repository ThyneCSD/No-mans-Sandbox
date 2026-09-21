using UnityEngine;

public class pressurePlate : MonoBehaviour
{
    private bool isPressed = false;

    private void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Object"))
        {
            Debug.Log("the thick thighs are on the pressure plate");
            isPressed = true;
        }
    }
}
