using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IngameNameChange : MonoBehaviour
{
    public GameObject ingameChangeNameMenu;

    public TMP_InputField inputField;
    public TMP_Text tmp_text;


    public void ChangeMenu()
    {
        ingameChangeNameMenu.SetActive(true);
    }

    public void InputText()
    {
        if (inputField.text.Length > 2 && inputField.text.Length < 10)
        {
            Time.timeScale = 1.0f;
            tmp_text.text = inputField.text;
            ingameChangeNameMenu.SetActive(false);
        }
    }
}
