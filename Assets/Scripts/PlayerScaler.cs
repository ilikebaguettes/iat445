using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScaler : MonoBehaviour
{
    public List<GameObject> objectsToScale;

    //public CharacterController characterController;
    //private float ogHeight;
    //private Vector3 ogCenter;
    //public float newHeight;
    //public Vector3 newCenter = new Vector3(2f, 2f, 2f);

    public float scaleDuration = 5.0f;
    public Vector3 targetScale = new Vector3(2f, 2f, 2f);

    public void StartScaling()
    {
        //characterController = GetComponent<CharacterController>();
        //ogHeight = characterController.height;
        //ogCenter = characterController.center;

        //characterController.height = newHeight;
        //characterController.center = newCenter;

        foreach (GameObject obj in objectsToScale)
        {
            StartCoroutine(ScaleOverTime(obj, targetScale, scaleDuration));
        }
    }

    IEnumerator ScaleOverTime(GameObject obj, Vector3 target, float duration)
    {
        if (obj == null) yield break;
        Vector3 startScale = obj.transform.localScale;
        float time = 0;

        while (time < duration)
        {
            obj.transform.localScale = Vector3.Lerp(startScale, target, time/duration);
            time += Time.deltaTime;
            yield return null;
        }

        obj.transform.localScale = target;
    } 
}
