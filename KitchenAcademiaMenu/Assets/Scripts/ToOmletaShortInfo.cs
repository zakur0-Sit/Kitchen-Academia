using UnityEngine;
using UnityEngine.SceneManagement;

public class ToOmletaShortInfo : MonoBehaviour
{
    public void OmletaShortInfo()
    {
        Debug.Log("OmletaShortInfo method called!"); // Mesaj de test
        SceneManager.LoadScene("Omleta ShortInfo");
    }
}
