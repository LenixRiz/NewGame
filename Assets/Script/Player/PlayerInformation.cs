using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInformation : MonoBehaviour
{

    [SerializeField] private TrainingSystem trainingSystem;

    // UI Elements
    public TextMeshProUGUI plrNameText;
    public TextMeshProUGUI plrHealthText;
    public TextMeshProUGUI plrStrengthText;
    public TextMeshProUGUI plrVitalityText;
    public TextMeshProUGUI plrDexterityText;
    public TextMeshProUGUI plrAgilityText;
    public TextMeshProUGUI plrIntellectualText;
    public TextMeshProUGUI plrSkillPointsText;

    // Player Info
    [SerializeField] string  plrName = "Player";
    [SerializeField] int plrHealth = 100;
    // Player Stats
    
    [SerializeField] private int plrStrength = 10;
    [SerializeField] private int plrVitality = 10;
    [SerializeField] private int plrDexterity = 10;
    [SerializeField] private int plrAgility = 10;
    [SerializeField] private int plrIntellectual = 10;
    [SerializeField] private int plrSkillPoints = 0;

    public int Strength
    {
        get => plrStrength;
        set
        {
            plrStrength = Math.Max(0, value); // Ensure strength is not negative
            UpdatePlrStats();
        }
    }
    public int Vitality
    {
        get => plrVitality;
        set
        {
            plrVitality = Math.Max(0, value); // Ensure vitality is not negative
            UpdatePlrStats();
        }
    }
    public int Dexterity
    {
        get => plrDexterity;
        set
        {
            plrDexterity = Math.Max(0, value); // Ensure dexterity is not negative
            UpdatePlrStats();
        }
    }
    public int Agility
    {
        get => plrAgility;
        set
        {
            plrAgility = Math.Max(0, value); // Ensure agility is not negative
            UpdatePlrStats();
        }
    }
    public int Intellectual
    {
        get => plrIntellectual;
        set
        {
            plrIntellectual = Math.Max(0, value); // Ensure intellectual is not negative
            UpdatePlrStats();
        }
    }
    public int SkillPoints
    {
        get => plrSkillPoints;
        set
        {
            plrSkillPoints = Math.Max(0, value); // Ensure skill points are not negative
            UpdatePlrStats();
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdatePlrName();
        UpdatePlrHealth();
        UpdatePlrStats();
    }

    public void UpdatePlrName()
    {
        plrNameText.text = $"Name: {plrName}";
        Debug.Log($"Player name updated: {plrName}");
    }

    public void UpdatePlrHealth()
    {
        plrHealthText.text = $"Health: {plrHealth}";
        Debug.Log($"Player health updated: {plrHealth}");
    }

    public void UpdatePlrStats()
    {
        if (trainingSystem != null)
        {
            plrStrengthText.text = $"Strength: {Strength}";
            plrVitalityText.text = $"Vitality: {Vitality}";
            plrDexterityText.text = $"Dexterity: {Dexterity}";
            plrAgilityText.text = $"Agility: {Agility}";
            plrIntellectualText.text = $"Wit: {Intellectual}";
            plrSkillPointsText.text = $"Skill Points: {SkillPoints}";
        }
        else
        {
            Debug.LogWarning("TrainingSystem is not assigned. Player stats will not be updated.");
        }
    }
}
