using UnityEngine;
using UnityEngine.UI;

public class FanButton : MonoBehaviour
{
    public Fan fan;
    public float cooldown = 0.5f;

    [Header("RawImages (each already has its own texture set)")]
    public RawImage powerOnImage;
    public RawImage powerOffImage;

    private float lastPressTime = -10f;
    private bool? lastShown = null;

    private void Update()
    {
        if (fan == null) return;
        if (lastShown == fan.isPowerOn) return;

        lastShown = fan.isPowerOn;
        ApplyVisual(fan.isPowerOn);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        if (Time.time - lastPressTime < cooldown) return;
        lastPressTime = Time.time;

        if (fan == null) return;

        fan.isPowerOn = !fan.isPowerOn;
        Debug.Log("Fan power: " + fan.isPowerOn);
    }

    private void ApplyVisual(bool on)
    {
        if (powerOnImage != null) powerOnImage.gameObject.SetActive(on);
        if (powerOffImage != null) powerOffImage.gameObject.SetActive(!on);
    }
}