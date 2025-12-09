using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPickUpDrop : MonoBehaviour
{

    [SerializeField] private Transform _playerCameraTransform;
    [SerializeField] private Transform objectPickupPointTransform;
    [SerializeField] private LayerMask _pickupLayerMask;
    [SerializeField] private float pickupDistance = 2f;
    [SerializeField] private InputActionAsset InputActions;

    private ObjectPickupable objectPickupable;

    private void OnInteract()
    {
        if (objectPickupable == null) {
        Debug.Log("Interacted");
        Debug.DrawRay(_playerCameraTransform.position, _playerCameraTransform.forward * 2f, Color.red, 2f);
        //first asks for what to use, we use a ref to an obj in scene then tells it to look forward
        if (Physics.Raycast(_playerCameraTransform.position, _playerCameraTransform.forward, out RaycastHit raycastHit, pickupDistance, _pickupLayerMask));
            Debug.Log(raycastHit.transform);
            if (raycastHit.transform.TryGetComponent(out objectPickupable))
        {
            objectPickupable.Pickup(objectPickupPointTransform);
            Debug.Log(objectPickupable);
        } 
        }else
        {
        objectPickupable.Drop();
        objectPickupable = null;
        }
    }
}
