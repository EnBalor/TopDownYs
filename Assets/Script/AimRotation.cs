using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.UIElements;

public class AimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;

    private Controller controller;

    private void Awake()
    {
        controller = GetComponent<Controller>();
    }

    // Start is called before the first frame update
    void Start()
    {
        controller.onLookEvent += OnAim;
    }

    private void OnAim(Vector3 dir)
    {
        Rotate(dir);
    }

    private void Rotate(Vector3 dir)
    {
        float rotZ = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        characterRenderer.flipX = Math.Abs(rotZ) > 90f;
    }


}
