// În ToProgress.cs
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToTutorial : MonoBehaviour
{
    public void LoadTutorialScene()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
