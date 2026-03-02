using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class Interactable : MonoBehaviour
{
    Outline outline;
    public string message;

    public UnityEvent onInteraction;

    public float captionDuration = -1.0f;

    private void Start()
    {
        outline = GetComponent<Outline>();
        DisableOutline();
    }

    private void Update()
    {
        captionDuration -= Time.deltaTime;

        if(captionDuration <= 0)
        {
            //stop displaying caption
        }
    }

    public void Interact()
    {
        onInteraction.Invoke();
    }

    public void DisableOutline()
    {
        outline.enabled = false;
    }

    public void EnableOutline()
    {
        outline.enabled = true;
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    //fix this method so it keeps the caption message up for n amt of time
    public void captionMessage(string captionMessage)
    {
        //start duration timer
        //captionDuration = 10.0f;
        HUDController.instance.EnableCaptionText(captionMessage);
        //HUDController.instance.DisableCaptionText(captionMessage);
    }
}