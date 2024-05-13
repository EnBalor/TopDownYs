using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time : MonoBehaviour
{
    public static string CurrnetTime()
    {
        return DateTime.Now.ToString(("HH:mm"));
    }
}
