using UnityEngine;

public class Fan : MonoBehaviour
{
    [SerializeField] private float windStrength;

    [SerializeField] private bool up;

    private void OnTriggerStay(Collider other)
    {
            if (other != null)
            {
                if (!up)
                {
                    other.gameObject.Move(Vector3.right * windStrength * Time.deltaTime);
                }
                else
                {
                    other.gameObject.Move(Vector3.up * windStrength * Time.deltaTime);
                }
            }
    }
}
