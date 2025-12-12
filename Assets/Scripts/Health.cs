using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] private float _current = 100f;
    [SerializeField] private float _max = 100f;


    [Header("Debug")]
    public float Percentage => _current/_max;
    public bool IsAlive => _current >= 1f;

    public void Damage(DamageInfo damageInfo)
    {
        if(!IsAlive) return; // stop if dead
        if(damageInfo.Amount < 1f) return; //ignore invalid damage amounts

        //reduce current health and clamp
        _current -= damageInfo.Amount;
        _current = Mathf.Clamp(_current, 0f, _max);

    }
}
