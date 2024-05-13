using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NameInput : MonoBehaviour
{
    public TMP_InputField inputField;
    public TMP_Text nameText;

    public GameObject textJoin;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0.0f;
    }

    public void JoinButton()
    {
        if(inputField.text.Length > 2 && inputField.text.Length < 10)
        {
            Time.timeScale = 1.0f;
            nameText.text = inputField.text;
            textJoin.SetActive(false);
        }
    }
}
