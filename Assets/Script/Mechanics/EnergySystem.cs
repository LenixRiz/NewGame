using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnergySystem : MonoBehaviour
{
    //UI Elements
    public TextMeshProUGUI energyText;
    public TextMeshProUGUI restConditionText;
    public Button restButton;
    public Button minusButton;

    [Range(0, 100)]
    [SerializeField] private float energy = 100F;
    public float Energy
    {
        get => energy;
        set
        {
            energy = Mathf.Clamp(value, minEnergy, maxEnergy);
            UpdateEnergyValue();
            UpdateEnergyText();
        }
    } // So the private field can be accessed by other classes
    [SerializeField] private float maxEnergy = 100F;
    [SerializeField] private float minEnergy = 0F;

    [SerializeField] Slider energyValue;
    private static readonly System.Random rng = new();

    void Start()
    {
        Energy = energy; // Initialize Energy property
        UpdateEnergyValue();
        UpdateEnergyText();
        restButton.onClick.AddListener(Rest);
        minusButton.onClick.AddListener(DecreaseEnergy);
    }

    public void Rest()
    {
        int rngValue = rng.Next(100);
        float energyGain;

        if (energy != maxEnergy)
        {
            if (rngValue < 20)
            {
                energyGain = 30F;
                restConditionText.text = "You are sleep deprived";
                Debug.Log("You are sleep deprived, you gain less energy (30).");
            }
            else if (rngValue < 80)
            {
                energyGain = 50F;
                restConditionText.text = "You are refreshed";
                Debug.Log("You are refreshed, you gain energy (50).");
            }
            else
            {
                energyGain = 70F;
                restConditionText.text = "You are well-rested";
                Debug.Log("You are well-rested, you gain much energy (70).");
            }
        }
        else
        {
            energyGain = 0F;
            restConditionText.text = "You are fully energized";
            Debug.Log("You are fully energized, no energy gained.");
        }
        Energy += energyGain;
    }

    public void DecreaseEnergy()
    {
        energy = Math.Clamp(energy - 25F, minEnergy, maxEnergy);;
        energyValue.value = energy;
        energyText.text = $"Energy: {energy}";
        Debug.Log($"Energy decreased by 25. Energy now: {energy}");
    }

    public void UpdateEnergyValue()
    {   
        if (energyValue != null)
        {
            energyValue.value = energy;
            Debug.Log($"Energy value slider updated to: {energyValue.value}");
        }
        else
        {
            Debug.LogWarning("EnergyValue slider is not assigned!");
        }
    }
    public void UpdateEnergyText()
    {
        if (energyText != null)
        {
            energyText.text = $"Energy: {energy}";
            Debug.Log($"Energy updated. Current energy: {energy}");
        }
        else
        {
            Debug.LogWarning("EnergyText is not assigned!");
        }
    }
}