using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : AnimationController
{
    protected static readonly int isWaking = Animator.StringToHash("isWalk");

    private readonly float threshold = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        controller.onMoveEvent += Move;
    }

    private void Move(Vector2 vector)
    {
        animator.SetBool(isWaking, vector.magnitude > threshold);
    }
}
