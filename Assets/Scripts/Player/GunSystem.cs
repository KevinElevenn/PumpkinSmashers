using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class GunSystem : MonoBehaviour
{
    [SerializeField] public Transform PlayerCameraTransform;
    public UnityEvent OnGunShoot;
    public float GunShootCooldown;
    
    private float _currentCooldown;

    void Start()
    {
        _currentCooldown = GunShootCooldown;
    }

    void FixedUpdate()
    {
        _currentCooldown -= Time.deltaTime;
    }

    private void OnLeftClick()
    {
        Debug.Log("Left Mouse Has Been Clicked Will Draw Yellow Ray Cast");
        Debug.DrawRay(PlayerCameraTransform.position, PlayerCameraTransform.forward * 2f, Color.blue, 2f);

            if (_currentCooldown <= 0f)
            {
                OnGunShoot?.Invoke();
                _currentCooldown = GunShootCooldown;
            }
    }

    }

