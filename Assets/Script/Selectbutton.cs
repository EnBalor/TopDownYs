using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selectbutton : MonoBehaviour
{
    public SpriteChange spriteChange;
    public PortraitChange portraitChange;
    public GameObject selectButton;

    public void PrintSelectMenu()
    {
        selectButton.SetActive(true);
    }

    public void ElfSelect()
    {
        spriteChange.SelectElf();
        if(portraitChange.gameObject.activeSelf)
        {
            portraitChange.ElfChange();
        }
        selectButton.SetActive(false);
    }

    public void DocSelect()
    {
        spriteChange.SelectDoc();
        Debug.Log(portraitChange.gameObject.activeSelf);
        if(portraitChange.gameObject.activeSelf)
        {
            portraitChange.DocChange();
        }
        selectButton.SetActive(false);
    }
}
