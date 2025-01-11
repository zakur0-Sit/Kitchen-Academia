using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class HistoryManager : MonoBehaviour
{
    [SerializeField] private Transform historyContainer;
    [SerializeField] private GameObject historyEntryPrefab;

    private void Start()
    {
        LoadHistory();
    }

    private void LoadHistory()
    {
        foreach (string key in PlayerPrefsKeys())
        {
            if (key.StartsWith("RecipeCompleted_") && PlayerPrefs.GetInt(key) == 1)
            {
                string recipeName = key.Replace("RecipeCompleted_", "");

                string completionDate = PlayerPrefs.GetString($"RecipeDate_{recipeName}");

                CreateHistoryEntry(recipeName, completionDate);
            }
        }
    }

    private void CreateHistoryEntry(string recipeName, string completionDate)
    {
        GameObject entry = Instantiate(historyEntryPrefab, historyContainer);

        Text[] texts = entry.GetComponentsInChildren<Text>();
        texts[0].text = recipeName;     
        texts[1].text = completionDate;     
    }

    private IEnumerable<string> PlayerPrefsKeys()
    {
        foreach (var key in PlayerPrefs.GetString("unity.playerprefs.keys", "").Split('|'))
        {
            yield return key;
        }
    }
}
