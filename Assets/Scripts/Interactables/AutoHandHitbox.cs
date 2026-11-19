using UnityEngine;

public class AutoHandHitbox : MonoBehaviour
{
    public float radius = 0.06f;

    private void Start()
    {
        GameObject hitbox = new GameObject("HandHitbox");
        hitbox.transform.SetParent(transform, false);
        hitbox.tag = "Player";

        SphereCollider col = hitbox.AddComponent<SphereCollider>();
        col.radius = radius;
        col.isTrigger = true;

        Rigidbody rb = hitbox.AddComponent<Rigidbody>();
        rb.isKinematic = true;
        rb.useGravity = false;
    }
}