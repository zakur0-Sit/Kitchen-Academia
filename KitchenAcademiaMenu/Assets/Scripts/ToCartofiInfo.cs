using UnityEngine;
using UnityEngine.SceneManagement;

public class ToCartofiInfo: MonoBehaviour
{
    public void CartofiInfo()
    {
        Debug.Log("OmletaShortInfo method called!"); // Mesaj de test
        SceneManager.LoadScene("Cartofi InfoRecipe");
    }
}
