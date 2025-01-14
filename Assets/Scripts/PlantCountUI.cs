using UnityEngine;
using TMPro;

public class PlantCountUI : MonoBehaviour
{
    // References to TMP_Text componenets that display the UI for the game
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;
    [SerializeField] private TMP_Text _plantedTextNum;
    [SerializeField] private TMP_Text _remainingTextNum;

    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        //Updates the UI to reflect the current number to seeds the player has planted and has left 
        _remainingTextNum.text = seedsLeft.ToString();
        _plantedTextNum.text = seedsPlanted.ToString();
    }
}