using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcTalk : MonoBehaviour
{
    public Transform player;
    public GameObject talkUI;
    public GameObject talkbar;

    public float detectRadius = 5f;

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.position);

        if(distance <= detectRadius)
        {
            talkUI.SetActive(true);
        }

        else
        {
            talkUI.SetActive(false);
        }
    }
}
