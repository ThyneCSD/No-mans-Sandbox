using UnityEngine;

public class Fan : MonoBehaviour
{
    [Range(0f, 100f)]
    public float fanSpeed;
    public bool isPowerOn = true;
    private void OnTriggerStay(Collider other)
    {
        if (!isPowerOn) return;
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
                rb.AddForce(Vector3.up * fanSpeed, ForceMode.Force);
        }
    }
}
