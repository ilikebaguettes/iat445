using UnityEngine;

public class DetectObject : MonoBehaviour
{
    public int SceneNum;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("SceneInteractable"))
        {
            ChangeScene();
        }
    }

    public void ChangeScene()
    {
        SceneTransitionManager.singleton.GoToSceneAsync(SceneNum);
    }
}
