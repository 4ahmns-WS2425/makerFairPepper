using UnityEngine;
using TMPro;

public class NameGenerator : MonoBehaviour
{
    private string[] simpleNames = { "Tiger", "Elephant", "Dolphin", "Lion", "Panda", "Giraffe" };
    private string[] colors = { "Red", "Blue", "Green", "Yellow", "Purple", "Orange" };

    public TMP_Text playerTextField;

    public void SetPlayerName()
    {
        playerTextField.text = GenerateNameForKids();
    }

    public string GenerateNameForKids()
    {
        // W�hle einen zuf�lligen Namen und eine zuf�llige Farbe
        string randomAnimal = simpleNames[Random.Range(0, simpleNames.Length)];
        string randomColor = colors[Random.Range(0, colors.Length)];

        return randomColor + " " + randomAnimal;
    }
}
