using UnityEngine;

public class pressurePlate : MonoBehaviour
{
    public GameObject keyPrefab;
    public float spawnOffset = 0.5f;

    private bool isPressed = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player") || isPressed) return;

        isPressed = true;
        Debug.Log("Pressure plate pressed!");

        if (keyPrefab != null)
        {
            Vector3 spawnPos = transform.position + (transform.up) * spawnOffset;
            Instantiate(keyPrefab, spawnPos, Quaternion.identity);
        }
    }
}