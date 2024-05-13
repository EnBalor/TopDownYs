using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public event Action<Vector2> onMoveEvent;
    public event Action<Vector3> onLookEvent;

    protected virtual void Awake()
    {

    }

    public void CallMoveEvent(Vector2 direction)
    {
        onMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector3 direction)
    {
        onLookEvent?.Invoke(direction);
    }
}
