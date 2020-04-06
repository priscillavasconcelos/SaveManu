using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeetAnnaScreen : Screen
{
    public Text suspects;
    void Start()
    {
        suspects.text = Texts.SUSPECTS;
        title.text = Texts.MEETING + "Anna";
        text.text = Texts.MEETING_ANNA;
    }
}
