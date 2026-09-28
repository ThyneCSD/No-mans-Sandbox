using UnityEngine;

public class Fan : MonoBehaviour
{
    [SerializeField] private float windStrength;

    [SerializeField] private bool up;

    private void OnTriggerStay(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            if (up)
            {
                rb.AddForce(Vector3.up * windStrength, ForceMode.Force);
            }
            else
            {
                rb.AddForce(Vector3.down * windStrength, ForceMode.Force);
            }
        }
    }
}
