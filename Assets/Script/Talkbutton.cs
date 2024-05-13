using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talkbutton : MonoBehaviour
{
    public GameObject talkbar;
    public GameObject talkUI;

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
