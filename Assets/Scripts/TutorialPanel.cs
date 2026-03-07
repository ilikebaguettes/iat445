using UnityEngine;

public class TutorialPanel : MonoBehaviour
{
    public GameObject panel;

    public void Trigger()
    {
        if (panel.activeInHierarchy == false)
        {
            panel.SetActive(true);
        }
        else
        {
            panel.SetActive(false);
        }
    }
}
