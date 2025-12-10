using NUnit.Framework;
using UnityEngine;

public class BreakableObjects : MonoBehaviour
{
    [SerializeField] private GameObject _newObj;
    [SerializeField] private GameObject _pumpkin;
    [SerializeField] private string _tagFilter = "Breaker";
    [SerializeField] private float _objMaxHP = 10f;
    private HealthSystem healthSystem;
    void Awake()
    {
        healthSystem = new HealthSystem(_objMaxHP);
        Debug.Log("Health: "+healthSystem.GetHealth());
    }

    void OnCollisionEnter(Collision other)
    {
        if ( other.gameObject.CompareTag(_tagFilter))
        {
            TakeDamage();
        }
    }
    void TakeDamage()
    {        
            healthSystem.Damage(10);
            Debug.Log("Health: "+healthSystem.GetHealth());
            if (_objMaxHP <= 0f)
            {
                Instantiate(_newObj);
                Destroy(_pumpkin);
            }
    }

}
