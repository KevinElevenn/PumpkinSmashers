using UnityEngine;

public class ObjectPickupable : MonoBehaviour
{
    private Rigidbody objectRigidbody;
    private Transform objectPickupPointTransform;

    private void Awake()
    {
        objectRigidbody = GetComponent<Rigidbody>();
    }
    public void Pickup(Transform objectPickupPointTransform)
    {
        this.objectPickupPointTransform = objectPickupPointTransform;
        objectRigidbody.useGravity = false;
    }

    public void Drop()
    {
        this.objectPickupPointTransform = null;
        objectRigidbody.useGravity = true;
    }
    private void FixedUpdate()
    {
        if (objectPickupPointTransform != null)
        {
            float lerpSpeed = 10f;
            Vector3 newPosition = Vector3.Lerp(transform.position, objectPickupPointTransform.position, Time.deltaTime * lerpSpeed);
            objectRigidbody.MovePosition(newPosition);
        }
    }
}
