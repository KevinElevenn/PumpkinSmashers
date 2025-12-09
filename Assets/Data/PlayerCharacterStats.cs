using UnityEngine;

[CreateAssetMenu(fileName = "PlayerCharacterStats", menuName = "Scriptable Objects/PlayerCharacterStats")]
public class PlayerCharacterStats : ScriptableObject
{
    [field: SerializeField] public int Points { get; private set; } = 100;
    [field: SerializeField] public int PumpkinsDestroyed { get; private set;} = 0;
}
