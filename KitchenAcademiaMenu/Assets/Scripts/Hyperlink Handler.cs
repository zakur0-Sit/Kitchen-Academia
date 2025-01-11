using UnityEngine;
using TMPro;

public class HyperlinkHandler : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;

    private void Awake()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            int linkIndex = TMP_TextUtilities.FindIntersectingLink(textMeshPro, Input.mousePosition, Camera.main);
            if (linkIndex != -1) 
            {
                TMP_LinkInfo linkInfo = textMeshPro.textInfo.linkInfo[linkIndex];
                string url = linkInfo.GetLinkID();
                Application.OpenURL(url);
            }
        }
    }
}
