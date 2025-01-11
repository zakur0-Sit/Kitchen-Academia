using UnityEngine;
using UnityEngine.UI;

public class RecipeProgressManager : MonoBehaviour
{
    [SerializeField] private Button[] recipeButtons;
    [SerializeField] private Color completedColor = Color.green;
    [SerializeField] private Color notCompletedColor = Color.yellow;

    private void Start()
    {
        for (int i = 0; i < recipeButtons.Length; i++)
        {
            int isCompleted = PlayerPrefs.GetInt($"RecipeCompleted_{i}", 0); // 0 = not completed, 1 = completed

            ColorBlock colors = recipeButtons[i].colors;
            colors.normalColor = isCompleted == 1 ? completedColor : notCompletedColor;
            recipeButtons[i].colors = colors;
        }
    }
}
