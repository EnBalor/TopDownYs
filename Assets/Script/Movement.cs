using System;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Controller controller;
    private Rigidbody2D movementRigidbody;

    private Vector2 movementDir = Vector2.zero;

    private void Awake()
    {
        controller = GetComponent<Controller>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.onMoveEvent += Move;
    }

    private void Move(Vector2 dir)
    {
        movementDir = dir;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDir);
    }

    private void ApplyMovement(Vector2 dir)
    {
        dir = dir * 5f;

        movementRigidbody.velocity = dir;
    }
}