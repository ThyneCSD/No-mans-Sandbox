using UnityEngine;
using UnityEngine.SceneManagement;


public class WinSwitch : MonoBehaviour
{
    [SerializeField] private string sceneName;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
