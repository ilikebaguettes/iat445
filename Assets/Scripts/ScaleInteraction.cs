using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class ScaleInteraction : MonoBehaviour
{
    public GameObject player;
    public GameObject objScript;
    public Vector3 targetScale = new Vector3(0.001f, 0.001f, 0.001f);

    private void Update()
    {
        if (!IsScaleApproxiamtely(player.transform.localScale, targetScale))
        {
            //Debug.Log("Player scale is NOT the target scale: " + player.transform.localScale);
            objScript.GetComponent<XRGrabInteractable>().enabled = false;
        }
        else
        {
            //Debug.Log("Player scale IS the target scale.");
            objScript.GetComponent<XRGrabInteractable>().enabled = true;
        }
    }

    private bool IsScaleApproxiamtely(Vector3 v1, Vector3 v2)
    {
        bool xEqual = Mathf.Approximately(v1.x, v2.x);
        bool yEqual = Mathf.Approximately(v1.y, v2.y);
        bool zEqual = Mathf.Approximately(v1.z, v2.z);

        return xEqual && yEqual && zEqual;
    }
}
