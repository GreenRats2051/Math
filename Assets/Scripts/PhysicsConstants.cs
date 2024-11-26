using UnityEngine;

[CreateAssetMenu(fileName = "PhysicsConstants", menuName = "ScriptableObjects/PhysicsConstants")]
public class PhysicsConstants : ScriptableObject
{
    [TextArea]
    public string[] formula = new string[] { "F = m * g", "A = ? * r?", "s = s/t", "p = mv", "N = A/t", "? = m/V", "M = Z + N" };
}
