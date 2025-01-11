// În ToProgress.cs
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToHistory : MonoBehaviour
{
    public void LoadHistoryScene()
    {
        SceneManager.LoadScene("History");
    }
}
