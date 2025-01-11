using UnityEngine;
using UnityEngine.SceneManagement;

public class ToSceneNavigator : MonoBehaviour
{
    [SerializeField] private string targetSceneName;

    public void ToSceneTargetScene()
    {
        if (!string.IsNullOrEmpty(targetSceneName))
        {
            SceneManager.LoadScene(targetSceneName);
        }
    }
}
