using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class SpriteChange : PlayerSprite
{
    Sprite sprite;
    AnimatorController controller;

    public void SelectDoc()
    {
        sprite = Resources.Load<Sprite>("Sprite/doc_idle_anim_f0");
        controller = Resources.Load<AnimatorController>("Animation/Doc");
        ChangeSprite(sprite, controller);
        DocAnimation();
    }

    public void SelectElf()
    {
        sprite = Resources.Load<Sprite>("Sprite/elf_m_idle_anim_f0");
        controller = Resources.Load<AnimatorController>("Animation/Elf");
        ChangeSprite(sprite, controller);
        ElfAnimation();
    }
}
