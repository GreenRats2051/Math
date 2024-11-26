using UnityEngine;
using TMPro;

public class PhysicsUI : MonoBehaviour
{
    public PhysicsConstants physicsConstants;
    public TMP_InputField OneInput;
    public TMP_InputField TwoInput;
    public TMP_Text formulaText;
    public TMP_Text resultText;
    public int index;

    private void Start()
    {
        formulaText.text = physicsConstants.formula[index];
    }

    public void CalculateWeight()
    {
        float resolution = PhysicsCalculations.CalculateWeight(float.Parse(OneInput.text), float.Parse(TwoInput.text));
        resultText.text = $"Результат:" + resolution;
    }

    public void CalsulateVelocityBody()
    {
        float resolution = PhysicsCalculations.CalculateWeight(float.Parse(OneInput.text), float.Parse(TwoInput.text));
        resultText.text = $"Результат:" + resolution;
    }

    public void CalsulatePowerPulse()
    {
        float resolution = PhysicsCalculations.CalculateWeight(float.Parse(OneInput.text), float.Parse(TwoInput.text));
        resultText.text = $"Результат:" + resolution;
    }

    public void CalculatePower()
    {
        float resolution = PhysicsCalculations.CalculateWeight(float.Parse(OneInput.text), float.Parse(TwoInput.text));
        resultText.text = $"Результат:" + resolution;
    }

    public void CalculateGravityForce()
    {
        float resolution = PhysicsCalculations.CalculateWeight(float.Parse(OneInput.text), float.Parse(TwoInput.text));
        resultText.text = $"Результат:" + resolution;
    }

    public void CalculateMassNumber()
    {
        float resolution = PhysicsCalculations.CalculateWeight(float.Parse(OneInput.text), float.Parse(TwoInput.text));
        resultText.text = $"Результат:" + resolution;
    }
}
