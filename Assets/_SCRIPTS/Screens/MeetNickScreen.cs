using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeetNickScreen : Screen
{
    public Text suspects;
    void Start()
    {
        suspects.text = Texts.SUSPECTS;
        title.text = Texts.MEETING + "Nick";
        text.text = Texts.MEETING_NICK;
    }
}
