using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadSelectRecipeScene()
    {
        SceneManager.LoadScene("SelectRecipe");
    }
}
