using UnityEngine;
using TMPro;

public class TurnTimeSystem : MonoBehaviour
{

    public TextMeshProUGUI turnTimeText;
    public TextMeshProUGUI playerAgeText;

    private int actionDone;
    private int turnTime = 1;
    private const int maxTurnTime = 24;
    private int plrAge = 3;
    private const int plrMaxAge = 65;
    public int ActionPoints
    {
        get => actionDone;
        set
        {
            actionDone = Mathf.Clamp(value, 0, 24);
            Debug.Log($"Action Points updated: {actionDone}");
        }
    }
    public int TurnTime
    {
        get => turnTime;
        set
        {
            turnTime = Mathf.Clamp(value, 1, maxTurnTime);
            Debug.Log($"Turn Time updated: {turnTime}");
        }
    }
    public int PlrAge
    {
        get => plrAge;
        set => plrAge = Mathf.Max(0, value); // Ensure age is not negative
    }

    void Start()
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        turnTimeText.text = $"Turn Time: {turnTime}/{maxTurnTime}";
        playerAgeText.text = $"Player Age: {plrAge}";
    }

    public void TurnAdd()
    {
        if (turnTime < maxTurnTime)
        {
            turnTime++;
            turnTimeText.text = $"Turn Time: {turnTime}/{maxTurnTime}";
            Debug.Log($"Turn Time increased to: {turnTime}");
        }
        else if (PlrAge <= plrMaxAge)
        {
            PlrAge++;
            playerAgeText.text = $"Player Age: {plrAge}";
            turnTime = 1; // Reset turn time after reaching max
            turnTimeText.text = $"Turn Time: {turnTime}/{maxTurnTime}";
            Debug.Log("Maximum Turn Time reached. Ageing player.");
        }
        else
        {
            Debug.Log("Maximum Age is reached. No Longer Alive.");
        }
    }
}
