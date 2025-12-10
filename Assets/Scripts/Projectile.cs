using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))]
public class Projectile : MonoBehaviour
{
    [Header("Projectile")]
    [SerializeField] private float _speed = 25f;
    [SerializeField] private float _range = 10f;
    [SerializeField] private float _;

    //TODO vfx trail

    //properties accessed by weapon
    [SerializeField] public float Damage { get; set;} = 10f;
    public int Team {get; set;}
    public GameObject Instigator {get; set;}

    [Header("Components")]
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private CapsuleCollider _collider;

    private Vector3 _spawnPosition;

    private void OValidate()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.useGravity = false;
        // continuous dynamic mode is more reliable for fast moving objects
        _rigidbody.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;

        _collider = GetComponent<CapsuleCollider>();
        _collider.isTrigger = true;
    }

    void Awake()
    {
        //LAUNCH THIS BITCH
        _rigidbody.linearVelocity = transform.forward * _speed;
        _spawnPosition = transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        // ignore friendlys player is teamate
        if(other.TryGetComponent(out Targetable possibleTarget) && possibleTarget.Team == Team) return;

        // previous check was false assume bad guy
        // attack to damage hit obj
        DamageInfo damageinfo = new DamageInfo(Damage, possibleTarget.gameObject, gameObject, Instigator, Damagetype.Physical);
        if (other.TryGetComponent(out HealthSystem)) healthSystem.Damage(damageInfo);
    }
}
