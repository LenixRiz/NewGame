using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TrainingSystem : MonoBehaviour
{

    [SerializeField] private EnergySystem energySystem;
    [SerializeField] private PlayerInformation playerInformation;
    [SerializeField] private TurnTimeSystem turnTimeSystem;

    private static readonly System.Random rng = new();

    public int TrainValue{get; private set;}

    public int SkillPointsGain{get; private set;}


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

    private void RollRngValues()
    {
        TrainValue = rng.Next(1, 6);
        SkillPointsGain = rng.Next(1, 4);
    }

    public void TrainStrength()
    {
        if (energySystem.Energy > 0)
        {
            Debug.Log($"Training Strength. Training Value: {TrainValue}, Skill Points Gain: {SkillPointsGain}");
            RollRngValues();
            playerInformation.Strength += TrainValue;
            playerInformation.SkillPoints += SkillPointsGain;
            energySystem.Energy -= rng.Next(10, 18);
            playerInformation.UpdatePlrStats();
            turnTimeSystem.TurnAdd();
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
            Debug.Log($"Training Vitality. Training Value: {TrainValue}, Skill Points Gain: {SkillPointsGain}");
            RollRngValues();
            playerInformation.Vitality += TrainValue;
            playerInformation.SkillPoints += SkillPointsGain;
            energySystem.Energy -= 25;
            playerInformation.UpdatePlrStats();
            turnTimeSystem.TurnAdd();
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
            Debug.Log($"Training Dexterity. Training Value: {TrainValue}, Skill Points Gain: {SkillPointsGain}");
            RollRngValues();
            playerInformation.Dexterity += TrainValue;
            playerInformation.SkillPoints += SkillPointsGain;
            energySystem.Energy -= 10;
            playerInformation.UpdatePlrStats();
            turnTimeSystem.TurnAdd();
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
            Debug.Log($"Training Agility. Training Value: {TrainValue}, Skill Points Gain: {SkillPointsGain}");
            RollRngValues();
            playerInformation.Agility += TrainValue;
            playerInformation.SkillPoints += SkillPointsGain;
            energySystem.Energy -= 15;
            playerInformation.UpdatePlrStats();
            turnTimeSystem.TurnAdd();
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
            Debug.Log($"Training Intellectual. Training Value: {TrainValue}, Skill Points Gain: {SkillPointsGain}");
            RollRngValues();
            playerInformation.Intellectual += TrainValue;
            playerInformation.SkillPoints += SkillPointsGain;
            energySystem.Energy -= 10;
            playerInformation.UpdatePlrStats();
            turnTimeSystem.TurnAdd();
        }
        else
        {
            restConditionText.text = "Not enough energy to train Intellectual!";
        }
    }
}
