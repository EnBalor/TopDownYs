using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talkbutton : NpcTalk
{
    public void Talk()
    {
        talkbar.SetActive(true);
        talkUI.SetActive(false);
    }

    public void TalkEnd()
    {
        talkbar.SetActive(false);
    }
}
