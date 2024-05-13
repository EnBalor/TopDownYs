using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurrentTime : MonoBehaviour
{
    public TMP_Text textMeshPro;

    private void Update()
    {
        string currentTime = DateTime.Now.ToString("HH:mm");

        textMeshPro.text = currentTime;
    }
}
