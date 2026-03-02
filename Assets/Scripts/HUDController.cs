using UnityEngine;
using TMPro;

public class HUDController : MonoBehaviour
{
    public static HUDController instance;

    private void Awake()
    {
        instance = this;
    }

    [SerializeField] TMP_Text interactionText;
    [SerializeField] TMP_Text captionText;

    public void EnableInteractionText(string text)
    {
        interactionText.text = text + " (F)";
        interactionText.gameObject.SetActive(true);
    }

    public void DisableInteractionText()
    {
        interactionText.gameObject.SetActive(false);
    }

    public void EnableCaptionText(string text)
    {
        captionText.text = text;
        captionText.gameObject.SetActive(true);
    }
    public void DisableCaptionText(string text)
    {
        captionText.gameObject.SetActive(false);
    }
}
