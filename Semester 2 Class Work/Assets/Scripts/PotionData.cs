using UnityEngine;

[CreateAssetMenu(fileName = "PotionData", menuName = "Scriptable Objects/PotionData")]
public class PotionData : ScriptableObject
{
    public string potionName;
    public int healthRestored;
}
