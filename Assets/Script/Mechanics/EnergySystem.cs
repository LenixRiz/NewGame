using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnergySystem : MonoBehaviour
{
    //UI Elements
    public TextMeshProUGUI energyText;
    public Button restButton;
    public Button minusButton;

    [Range(0, 100)]
    [SerializeField] float energy = 100F;
    [SerializeField] float maxEnergy = 100F;
    [SerializeField] float minEnergy = 0F;

    [SerializeField] Slider energyValue;
    private static readonly System.Random rng = new();

    void Start()
    {
        // UpdateEnergyValue();
        UpdateEnergyText();
        restButton.onClick.AddListener(Rest);
        minusButton.onClick.AddListener(DecreaseEnergy);
    }

    public void Rest()
    {
        int rngValue = rng.Next(100);
        float energyGain;

        if (rngValue < 20)
        {
            energyGain = 30F;
            Debug.Log("You are sleep deprived, you gain less energy (30).");
        }
        else if (rngValue < 80)
        {
            energyGain = 50F;
            Debug.Log("You are refreshed, you gain energy (50).");
        }
        else
        {
            energyGain = 70F;
            Debug.Log("You are well-rested, you gain much energy (70).");
        }

        energy = Math.Clamp(energy + energyGain, minEnergy, maxEnergy);
        energyValue.value = energy;
        UpdateEnergyText();
        UpdateEnergyValue();
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
        energyValue.value = energy;
        Debug.Log($"Energy value slider updated to: {energyValue.value}");
    }
    public void UpdateEnergyText()
    {
        energyText.text = $"Energy: {energy}";
        Debug.Log($"Energy updated. Current energy: {energy}");
    }
}