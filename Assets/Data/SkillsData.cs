using UnityEngine;

[CreateAssetMenu(fileName = "SkillsData", menuName = "Scriptable Objects/SkillsData")]
public class SkillsData : ScriptableObject
{
     [field: SerializeField] public string SkillName {get; set;} = "Double Strength";
    [field: SerializeField] public string Description {get; set;} = "Doubles Throw Distance";
    [field: SerializeField] public SkillRarity Rarity {get; set;} = SkillRarity.Common;
    [field: SerializeField] public int Cost {get; set;} = 5;
    [field: SerializeField] public float Cooldown {get; set;} = 5f;
    [field: SerializeField] public int Damage {get; set;} = 5;
    [field: SerializeField] public float Range {get; set;} = 5f;
    [field: SerializeField] public float ThrowStrength {get; set;} = 5f;


    public enum SkillRarity
    {
        Common,
        Uncommon,
        Rare,
        Legendary,
        Mytic
    }

}
