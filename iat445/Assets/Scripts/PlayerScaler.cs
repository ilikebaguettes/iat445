using System.Collections;
using UnityEngine;

public class PlayerScaler : MonoBehaviour
{
    public float scaleDuration = 5.0f;
    public Vector3 targetScale = new Vector3(2f, 2f, 2f);

    private Coroutine scaleCoroutine;

    public void StartScaling()
    {
        if(scaleCoroutine != null) StopCoroutine(scaleCoroutine);
        scaleCoroutine = StartCoroutine(ScaleOverTime(targetScale, scaleDuration));
    }

    IEnumerator ScaleOverTime(Vector3 target, float duration)
    {
        Vector3 startScale = transform.localScale;
        float time = 0;

        while (time < duration)
        {
            transform.localScale = Vector3.Lerp(startScale, target, time/duration);
            time += Time.deltaTime;
            yield return null;
        }

        transform.localScale = target;
    } 
}
