using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeetTomScreen : Screen
{
    void Start()
    {
        title.text = Texts.SUSPECTS;
        subtitle.text = Texts.MEETING + "Tom";
        text.text = Texts.MEETING_TOM;
    }
}
