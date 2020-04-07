using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeetSaraScreen : Screen
{
    void Start()
    {
        title.text = Texts.SUSPECTS;
        subtitle.text = Texts.MEETING + "Sara";
        text.text = Texts.MEETING_SARA;
    }
}
