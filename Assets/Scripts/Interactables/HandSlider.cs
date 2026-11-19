using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HandSlider : MonoBehaviour
{
    private Slider slider;
    private RectTransform rect;

    private void Awake()
    {
        slider = GetComponent<Slider>();
        rect = (RectTransform)transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Slider trigger entered by: " + other.name + " tag: " + other.tag);
    }

    private void OnTriggerStay(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        Vector3 local = rect.InverseTransformPoint(other.bounds.center);
        float t = Mathf.InverseLerp(rect.rect.xMin, rect.rect.xMax, local.x);
        slider.normalizedValue = t;
        Debug.Log("Slider value set to " + slider.value);
    }
}