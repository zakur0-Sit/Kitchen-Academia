using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SelectRecipeManager : MonoBehaviour
{
    public void SelectRecipe(int recipeIndex)
    {
        PlayerPrefs.SetInt($"RecipeCompleted_{recipeIndex}", 1);
        PlayerPrefs.Save();
    }

    public void CompleteRecipe(string recipeName)
    {
        PlayerPrefs.SetInt($"RecipeCompleted_{recipeName}", 1);

        string completionDate = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        PlayerPrefs.SetString($"RecipeDate_{recipeName}", completionDate);

        PlayerPrefs.Save();
        Debug.Log($"Rețeta {recipeName} completată la {completionDate}");
    }
}
