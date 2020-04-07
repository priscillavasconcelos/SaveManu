using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeetNickScreen : Screen
{
    void Start()
    {
        title.text = Texts.SUSPECTS;
        subtitle.text = Texts.MEETING + "Nick";
        text.text = Texts.MEETING_NICK;
    }
}
