using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeetAnnaScreen : Screen
{
    void Start()
    {
        title.text = Texts.SUSPECTS;
        subtitle.text = Texts.MEETING + "Anna";
        text.text = Texts.MEETING_ANNA;
    }
}
