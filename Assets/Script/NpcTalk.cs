using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcTalk : MonoBehaviour
{
    public Transform player;
    public GameObject talkUI;
    public GameObject talkbar;
    protected bool isTalk = false;

    public float detectRadius = 5f;

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.position);

        if(distance <= detectRadius && isTalk == false)
        {
            talkUI.SetActive(true);
        }

        else
        {
            talkUI.SetActive(false);
        }
    }
}
