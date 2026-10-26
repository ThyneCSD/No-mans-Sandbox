using UnityEngine;

public class Ifstatement : MonoBehaviour
{
    [SerializeField] private Button Button;
    [SerializeField] private GameObject keyCard;

    private bool hasSpawned = false;
    private void Update()
    {
        if (Button.wasPressed && !hasSpawned)
        {
            Instantiate(keyCard, transform.position + Vector3.up * 1, transform.rotation);
            hasSpawned = true;
        }
    }
}