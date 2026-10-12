using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonSwitch : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("MainScene");
    }
}
