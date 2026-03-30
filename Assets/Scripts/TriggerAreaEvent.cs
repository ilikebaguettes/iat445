using UnityEngine;

public class TriggerAreaEvent : MonoBehaviour
{
    public int SceneNum;
    public PlayerScaler scaler;
    public FadeScreen fadeScreen;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collision detected");

        if (other.gameObject.CompareTag("Player"))
        {
            // move doors, create nail object
        }
    }

    public void MoveDoors()
    {

    }
}
