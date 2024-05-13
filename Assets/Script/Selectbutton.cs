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
        portraitChange.ElfChange();
        selectButton.SetActive(false);
    }

    public void DocSelect()
    {
        spriteChange.SelectDoc();
        portraitChange.DocChange();
        selectButton.SetActive(false);
    }
}
