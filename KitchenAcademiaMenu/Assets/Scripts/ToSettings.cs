// În ToProgress.cs
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToSettings : MonoBehaviour
{
    public void LoadSettingsScene()
    {
        SceneManager.LoadScene("Settings");
    }
}
