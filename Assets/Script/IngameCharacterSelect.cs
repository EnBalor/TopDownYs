using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngameCharacterSelect : MonoBehaviour
{
    public GameObject CharacterSelect;

    // Update is called once per frame
    public void IngameSelectPrint()
    {
        Debug.Log("change");
        CharacterSelect.SetActive(true);
    }
}
