using UnityEngine;
using UnityEngine.SceneManagement;

public class ToProgress : MonoBehaviour
{
    public void LoadProgressScene()
    {
        SceneManager.LoadScene("Progress");
    }
}
