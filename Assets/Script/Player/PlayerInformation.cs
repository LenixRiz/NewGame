using TMPro;
using UnityEngine;

public class PlayerInformation : MonoBehaviour
{

    public TrainingSystem trainingSystem;

    // UI Elements
    public TextMeshProUGUI plrNameText;
    public TextMeshProUGUI plrHealthText;
    public TextMeshProUGUI plrStrengthText;
    public TextMeshProUGUI plrVitalityText;
    public TextMeshProUGUI plrDexterityText;
    public TextMeshProUGUI plrAgilityText;
    public TextMeshProUGUI plrWitText;

    // Player Info
    [SerializeField] string  plrName = "Player";
    [SerializeField] int plrHealth = 100;
    // Player Stats
    readonly int plrStrength;
    readonly int plrVitality;
    readonly int plrDexterity;
    readonly int playerAgility;
    readonly int plrWit;

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
        plrStrengthText.text = $"Strength: {plrStrength}";
        plrVitalityText.text = $"Vitality: {plrVitality}";
        plrDexterityText.text = $"Dexterity: {plrDexterity}";
        plrAgilityText.text = $"Agility: {playerAgility}";
        plrWitText.text = $"Wit: {plrWit}";
    }
}
