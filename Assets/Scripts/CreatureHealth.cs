using UnityEngine;

public class CreatureHealth : MonoBehaviour
{
    private HealthSystem healthSystem;
    //[SerializeField] private int MaxHealth = 100;

    void Awake()
    {
        healthSystem = new HealthSystem(1000);
        Debug.Log("Health: "+healthSystem.GetHealthPercent());
        //test code below remove
        healthSystem.Damage(1);
        Debug.Log("Health: "+healthSystem.GetHealthPercent());
    }
}
