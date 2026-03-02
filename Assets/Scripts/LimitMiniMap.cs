using UnityEngine;

public class LimitMiniMap : MonoBehaviour
{
    public GameObject Player;

    private void LateUpdate()
    {
        transform.position = new Vector3(Player.transform.position.x, 40, Player.transform.position.z);
    }
}
