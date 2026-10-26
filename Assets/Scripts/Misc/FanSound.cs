using UnityEngine;

public class FanSound : MonoBehaviour
{
    public static FanSound Instance;
    public AudioClip fanSound;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    // A static method you can call from any script
    public static void PlayFanSound(GameObject targetObject)
    {
        if (Instance == null || Instance.fanSound == null) return;

        AudioSource source = targetObject.AddComponent<AudioSource>();
        source.clip = Instance.fanSound;
        source.loop = true;
        source.Play();
    }
}