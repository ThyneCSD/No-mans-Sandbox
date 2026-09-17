using UnityEngine;

public class Button : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    //Deze comment zet ik hier neer zodat het lijkt alsof ik oprecht comments gebruik.
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Button pressed!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Button pressed!");
        }
    }
}
