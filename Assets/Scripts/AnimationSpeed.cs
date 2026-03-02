using UnityEngine;

public class AnimationSpeed : MonoBehaviour
{
    Animator anim;
    public GameObject Player;

    void Awake()
    {
        anim = GetComponent<Animator>();
        ChangeAnimationSpeed();
    }

    void ChangeAnimationSpeed()
    {
        Vector3 playerScale = Player.transform.localScale;
        anim.speed = 1 * playerScale.x;   
    }
}
