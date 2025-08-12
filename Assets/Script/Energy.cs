using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Energy : MonoBehaviour
{

    public Text energyText;
    public Button restButton;

    [SerializeField] private int energy = 100;
    private readonly System.Random rng = new System.Random();
    private int rngValue;

    private void Awake()
    {
        rngValue = rng.Next(0, 100);
    }

    public class Rest
    {

        public int energy;
        public int rngValue;

        public Rest(int energy, int rngValue)
        {
            this.energy = energy;
            this.rngValue = rngValue;
            Debug.Log($"Resting... Energy: {energy}, RNG Value: {rngValue}");
        }

        public void RestoreEnergy(int energy)
        {
            if (rngValue < 20)
            {
                energy += 30;
                Debug.Log($"You are sleep depreived. Energy restored by 30. Current energy: {energy}");
            }
            else if (rngValue < 50)
            {
                energy += 50;
                Debug.Log($"You are all rested. Energy restored by 50. Current energy: {energy}");
            }
            else
            {
                energy += 70;
                Debug.Log($"You are well rested. Energy restored by 70. Current energy: {energy}");
            }
        }

    }

    void Start()
    {
        energyText.text = $"Energy: {energy}";
    }
    void Update()
    {
        
    }
}
