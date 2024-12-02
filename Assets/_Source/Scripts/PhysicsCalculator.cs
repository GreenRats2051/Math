using Unity.VisualScripting;
using UnityEngine;

public static class PhysicsCalculations
{
    public static float CalculateWeight(float mass, float gravity)
    {
        return mass * gravity;
    }

    public static float CalsulateVelocityBody(float way, float time)
    {
        return way / time;
    }

    public static float CalsulatePowerPulseFormula(float mass, float speed)
    {
        return mass * speed;
    }

    public static float CalculatePowerFormula(float work, float time)
    {
        return work / time;
    }

    public static float CalculateGravityForce(float mass, float bodyVolume)
    {
        return mass / bodyVolume;
    }

    public static float CalculateMassNumber(float chargeNumber, float numberNeutrons)
    {
        return chargeNumber + numberNeutrons;
    }
}
