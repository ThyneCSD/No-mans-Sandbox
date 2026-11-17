using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit.UI;

[RequireComponent(typeof(Canvas))]
public class VRCanvasFixer : MonoBehaviour
{
    [Header("Placement")]
    public bool placeInFrontOfPlayer = true;
    public float distance = 1.5f;
    public float canvasScale = 0.002f;

    private void Start()
    {
        Camera cam = Camera.main;
        if (cam == null) cam = FindFirstObjectByType<Camera>();

        SetupCanvas(cam);
        SetupRaycaster();
        SetupEventSystem();
        EnableUIOnInteractors();
    }

    private void SetupCanvas(Camera cam)
    {
        Canvas canvas = GetComponent<Canvas>();
        canvas.renderMode = RenderMode.WorldSpace;
        canvas.worldCamera = cam;
        transform.localScale = Vector3.one * canvasScale;

        if (placeInFrontOfPlayer && cam != null)
        {
            Vector3 forward = cam.transform.forward;
            forward.y = 0f;
            if (forward.sqrMagnitude < 0.001f) forward = Vector3.forward;
            forward.Normalize();

            transform.position = cam.transform.position + forward * distance;
            transform.rotation = Quaternion.LookRotation(forward);
        }
    }

    private void SetupRaycaster()
    {
        GraphicRaycaster oldRaycaster = GetComponent<GraphicRaycaster>();
        if (oldRaycaster != null) Destroy(oldRaycaster);

        if (GetComponent<TrackedDeviceGraphicRaycaster>() == null)
            gameObject.AddComponent<TrackedDeviceGraphicRaycaster>();
    }

    private void SetupEventSystem()
    {
        EventSystem es = FindFirstObjectByType<EventSystem>();
        if (es == null)
            es = new GameObject("EventSystem").AddComponent<EventSystem>();

        foreach (BaseInputModule module in es.GetComponents<BaseInputModule>())
        {
            if (!(module is XRUIInputModule)) Destroy(module);
        }

        if (es.GetComponent<XRUIInputModule>() == null)
            es.gameObject.AddComponent<XRUIInputModule>();
    }

    private void EnableUIOnInteractors()
    {
        int count = 0;

        foreach (MonoBehaviour behaviour in FindObjectsByType<MonoBehaviour>(FindObjectsSortMode.None))
        {
            if (!(behaviour is IUIInteractor)) continue;

            var type = behaviour.GetType();

            var prop = type.GetProperty("enableUIInteraction");
            if (prop != null && prop.CanWrite)
            {
                prop.SetValue(behaviour, true);
                count++;
                continue;
            }

            var field = type.GetField("m_EnableUIInteraction",
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Public);
            if (field != null)
            {
                field.SetValue(behaviour, true);
                count++;
            }
        }

        Debug.Log("VRCanvasFixer done. UI interactors enabled: " + count);
    }
}