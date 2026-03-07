using UnityEngine;

public class TriggerScene : MonoBehaviour
{
    public int sceneNum;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneTransitionManager.singleton.GoToSceneAsync(sceneNum);
        }
    }
}
