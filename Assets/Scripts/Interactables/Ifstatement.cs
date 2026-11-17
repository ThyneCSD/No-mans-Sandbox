using UnityEngine;

public class Ifstatement : MonoBehaviour
{
    [SerializeField] private PressButton button;
    [SerializeField] private GameObject keyCard;

    private bool hasSpawned = false;

    private void Start()
    {
        Debug.Log("Ifstatement started. button: " + button + " keyCard: " + keyCard);
    }

    private void Update()
    {
        if (button == null || keyCard == null) return;

        if (button.wasPressed && !hasSpawned)
        {
            Vector3 pos = transform.position + Vector3.up;
            Instantiate(keyCard, pos, transform.rotation);
            hasSpawned = true;
            Debug.Log("Key spawned at " + pos);
        }
    }
}