using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject.transform);
    }
}
