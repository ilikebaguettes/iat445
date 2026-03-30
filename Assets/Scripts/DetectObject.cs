using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectObject : MonoBehaviour
{
    public int SceneNum;
    public PlayerScaler scaler;
    public FadeScreen fadeScreen;
    public GameObject player;

    public Vector3 targetScale = new Vector3(0.5f, 0.5f, 0.5f);

    public Vector3 targetPosition = new Vector3(0f, 2f, 0f);

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collision detected");

        if (other.gameObject.CompareTag("SceneInteractable"))
        {
            ShrinkPlayer();
            FadeScreen();
            StartCoroutine(DelayMoveCoroutine(4.5f));
        }
        if (other.gameObject.CompareTag("Player"))
        {
            ChangeScene();
        }
    }

    public void ChangeScene()
    {
        SceneTransitionManager.singleton.GoToSceneAsync(SceneNum);
    }

    public void MovePlayer()
    {
        player.transform.position = targetPosition;
    }

    public void FadeScreen()
    {
        fadeScreen.FadeOut();
    }

    public void FadeInScreen()
    {
        fadeScreen.FadeIn();
    }

    public void ShrinkPlayer()
    {
        scaler.targetScale = targetScale;
        scaler.StartScaling();
    }

    IEnumerator DelayMoveCoroutine(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        FadeInScreen();
        MovePlayer();

    }

    public void DelayedMove()
    {
        ShrinkPlayer();
        FadeScreen();
        StartCoroutine(DelayMoveCoroutine(5f));
    }
}
