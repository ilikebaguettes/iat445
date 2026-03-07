using System.Collections;
using UnityEngine;

public class PlayerScaler : MonoBehaviour
{
    public float duration;
    public float targetScale; 

    public void StartScaling()
    {
        StartCoroutine(ScaleOverTime(duration, targetScale));
    }

    private IEnumerator ScaleOverTime(float duration, float scale)
    {
        Vector3 startScale = transform.localScale;
        Vector3 endScale = Vector3.one * scale;
        float elapsed = 0f;

        while (elapsed < duration)
        {
            float t = elapsed / duration;
            transform.localScale = Vector3.Lerp(startScale, endScale, t);
            elapsed += Time.deltaTime;
            yield return null;
        }

        transform.localScale = endScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
