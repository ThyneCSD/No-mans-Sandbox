using UnityEngine;

public class Key : MonoBehaviour
{
    private bool openDoor = false;
    private float openTimer = 0f;
    public float openDuration = 1f;
    public float speed = 1f;

    private void Update()
    {
        if (!openDoor)
            return;

        openTimer += Time.deltaTime;

        if (openTimer >= openDuration)
        {
            openDoor = false;
            return;
        }

        transform.position += Vector3.up * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Key") && !openDoor)
        {
            openDoor = true;
            openTimer = 0f;
            Debug.Log("Door opened");
        }
    }
}
