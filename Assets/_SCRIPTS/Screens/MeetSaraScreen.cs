using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeetSaraScreen : Screen
{
    public Text suspects;
    void Start()
    {
        suspects.text = Texts.SUSPECTS;
        title.text = Texts.MEETING + "Sara";
        text.text = Texts.MEETING_SARA;
    }
}
