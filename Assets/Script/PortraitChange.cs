using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.U2D;
using UnityEngine.UI;

public class PortraitChange : MonoBehaviour
{
    public Image _image;


    private void Awake()
    {
        _image = GetComponent<Image>();
    }
    // Start is called before the first frame update
    public void ElfChange()
    {
        Sprite sprite = Resources.Load<Sprite>("Sprite/elf_m_idle_anim_f0");
        _image.sprite = sprite;
    }

    public void DocChange()
    {
        Sprite sprite = Resources.Load<Sprite>("Sprite/doc_idle_anim_f0");
        _image.sprite = sprite;
    }
}
