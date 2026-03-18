using UnityEngine;

public class DetectObject : MonoBehaviour
{
    public int SceneNum;
    public PlayerScaler scaler;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("SceneInteractable"))
        {
            //ChangeScene();
            ShrinkPlayer();
        }
    }

    public void ChangeScene()
    {
        SceneTransitionManager.singleton.GoToSceneAsync(SceneNum);
    }

    public void ShrinkPlayer()
    {
        scaler.StartScaling();
    }
}
