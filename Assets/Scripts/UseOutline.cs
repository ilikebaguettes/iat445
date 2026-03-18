using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class UseOutline : MonoBehaviour
{
    public Outline outline;

    public void onOutline()
    {
        outline.enabled = true;
    }

    public void offOutline()
    {
        outline.enabled = false;
    }
}
