using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonSwitch : MonoBehaviour
{
    [SerializeField] private string sceneName;
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(sceneName);
    }
}
