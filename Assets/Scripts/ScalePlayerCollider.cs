using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class ScalePlayerCollider : MonoBehaviour
{
    public GameObject player;
    public Vector3 targetScale = new Vector3(0.01f, 0.01f, 0.01f);

    public CharacterController characterController;
    private float ogHeight;
    private Vector3 ogCenter;
    private float ogRadius;
    public float newHeight;
    public float newRadius;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        ogHeight = characterController.height;
        ogCenter = characterController.center;
        ogRadius = characterController.radius;
    }
    private void Update()
    {
        if (!IsScaleApproxiamtely(player.transform.localScale, targetScale))
        {
            Debug.Log("Player scale is NOT the target scale: " + player.transform.localScale);
        }
        else
        {
            Debug.Log("Player scale IS the target scale.");
            characterController.height = newHeight;
            characterController.radius = newRadius;
        }
    }

    private bool IsScaleApproxiamtely(Vector3 v1, Vector3 v2)
    {
        bool xEqual = Mathf.Approximately(v1.x, v2.x);
        bool yEqual = Mathf.Approximately(v1.y, v2.y);
        bool zEqual = Mathf.Approximately(v1.z, v2.z);

        return xEqual && yEqual && zEqual;
    }
}
