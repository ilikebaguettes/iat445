using System.Collections;
using UnityEngine;

public class PlayerScaler : MonoBehaviour
{
    public float duration;
    public float targetScale;

    //private BoxCollider boxCollider;

    public Terrain terrain;
    public float grassSlow;


    public void StartScaling()
    {
        StartCoroutine(ScaleOverTime(duration, targetScale));
    }

    private IEnumerator ScaleOverTime(float duration, float scale)
    {
        //boxCollider = GetComponent<BoxCollider>();
        Vector3 startScale = transform.localScale;
        Vector3 endScale = Vector3.one * scale;
        float elapsed = 0f;

        while (elapsed < duration)
        {
            terrain.terrainData.wavingGrassSpeed = grassSlow;

            //boxCollider.size = new Vector3(endScale, endScale, endScale);

            float t = elapsed / duration;
            transform.localScale = Vector3.Lerp(startScale, endScale, t);
            elapsed += Time.deltaTime;
            yield return null;
        }

        transform.localScale = endScale;
    }
}