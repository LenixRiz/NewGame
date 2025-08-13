using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TrainingSystem : MonoBehaviour
{

    [SerializeField] private EnergySystem energySystem;
    [SerializeField] private PlayerInformation playerInformation;

    private static readonly System.Random rng = new();
    private readonly int trainValue = rng.Next(2, 11);
    private readonly int skillPointsGain = rng.Next(1, 4);

    // UI Elements
    public Button StrengthTrainButton;
    public Button VitalityTrainButton;
    public Button DexterityTrainButton;
    public Button AgilityTrainButton;
    public Button IntellectualTrainButton;
    public TextMeshProUGUI restConditionText;

    void Start()
    {   
        StrengthTrainButton.onClick.AddListener(TrainStrength);
        VitalityTrainButton.onClick.AddListener(TrainVitality);
        DexterityTrainButton.onClick.AddListener(TrainDexterity);
        AgilityTrainButton.onClick.AddListener(TrainAgility);
        IntellectualTrainButton.onClick.AddListener(TrainIntellectual);
    }

    public void TrainStrength()
    {
        if (energySystem.Energy > 0)
        {
            Debug.Log("Training Strength");
            playerInformation.Strength += trainValue;
            playerInformation.SkillPoints += skillPointsGain;
            energySystem.Energy -= rng.Next(10, 18);
            playerInformation.UpdatePlrStats();
        }
        else
        {
            restConditionText.text = "Not enough energy to train Strength!";
        }
    }

    public void TrainVitality()
    {
        if (energySystem.Energy > 0)
        {
            Debug.Log("Training Vitality");
            playerInformation.Vitality += trainValue;
            playerInformation.SkillPoints += skillPointsGain;
            energySystem.Energy -= 25;
            playerInformation.UpdatePlrStats();
        }
        else
        {
            restConditionText.text = "Not enough energy to train Vitality!";
        }
        
    }

    public void TrainDexterity()
    {
        if (energySystem.Energy > 0)
        {
            Debug.Log("Training Dexterity");
            playerInformation.Dexterity += trainValue;
            playerInformation.SkillPoints += skillPointsGain;
            energySystem.Energy -= 10;
            playerInformation.UpdatePlrStats();
        }
        else
        {
            restConditionText.text = "Not enough energy to train Dexterity!";
        }
        
    }

    public void TrainAgility()
    {
        if (energySystem.Energy > 0)
        {
            Debug.Log("Training Agility");
            playerInformation.Agility += trainValue;
            playerInformation.SkillPoints += skillPointsGain;
            energySystem.Energy -= 15;
            playerInformation.UpdatePlrStats();
        }
        else
        {
            restConditionText.text = "Not enough energy to train Agility!";
        }
    }

    public void TrainIntellectual()
    {
        if (energySystem.Energy > 0)
        {
            Debug.Log("Training Intellectual");
            playerInformation.Intellectual += trainValue;
            playerInformation.SkillPoints += skillPointsGain;
            energySystem.Energy -= 10;
            playerInformation.UpdatePlrStats();
        }
        else
        {
            restConditionText.text = "Not enough energy to train Intellectual!";
        }
    }
}
