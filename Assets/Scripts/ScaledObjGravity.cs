using UnityEngine;

public class ScaledObjGravity : MonoBehaviour
{
    private Rigidbody rb;
    public float bGravity = 3500.0f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(0, -1.0f, 0) * rb.mass * bGravity);
    }
}
