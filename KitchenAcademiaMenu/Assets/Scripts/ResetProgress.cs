using UnityEngine;
using UnityEngine.UI;

public class ResetProgressManager : MonoBehaviour
{
    [SerializeField] private Button resetButton;
    [SerializeField] private Button[] recipeButtons;
    [SerializeField] private Color notCompletedColor = Color.yellow;

    private void Start()
    {
        resetButton.onClick.AddListener(ResetProgress);
    }

    private void ResetProgress()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();

        foreach (var button in recipeButtons)
        {
            ColorBlock colors = button.colors;
            colors.normalColor = notCompletedColor;
            button.colors = colors;
        }

        Debug.Log("Progresul a fost resetat!");
    }
}
