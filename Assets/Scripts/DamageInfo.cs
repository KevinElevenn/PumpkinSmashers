using UnityEngine;

public class DamageInfo
{
    public DamageInfo(float amount, GameObject victim, GameObject source, GameObject instigator, DamageType damageType)
    {
        Amount = amount;
        Victim = victim;
        Source = source;
        Instigator = instigator;
        DamageType = damageType;
    }

    public float Amount {get; set; }
    public GameObject Victim {get; set;} //person or thing getting shot
    public GameObject Source {get; set;} // bullet that hit the person or thing
    public GameObject Instigator {get; set;} //person that shot
    public DamageType DamageType {get; set;}
}
    public enum DamageType
    {
        None,
        Physical,
        Fire
    }
 
