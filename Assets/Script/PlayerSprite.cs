using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class PlayerSprite : MonoBehaviour
{
    protected SpriteRenderer spriteRenderer;
    protected Animator animator;

    private void Start()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        animator = GetComponentInChildren<Animator>();
    }

    public void ChangeSprite(Sprite sprite, AnimatorController controller)
    {
        spriteRenderer.sprite = sprite;
        animator.runtimeAnimatorController = controller;

        
    }
    public void DocAnimation()
    {
        animator.Play("Doc_Idle");
    }

    public void ElfAnimation()
    {
        animator.Play("Elf_Idle");
    }
}
