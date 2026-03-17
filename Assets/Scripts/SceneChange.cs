using UnityEngine;

public class SceneChange : MonoBehaviour
{
    public int SceneNum;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ChangeScene();
        }
    }

    public void ChangeScene()
    {
        SceneTransitionManager.singleton.GoToSceneAsync(SceneNum);
    }
}