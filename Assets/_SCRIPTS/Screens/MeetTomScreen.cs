using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeetTomScreen : Screen
{
    public Text suspects;
    void Start()
    {
        suspects.text = Texts.SUSPECTS;
        title.text = Texts.MEETING + "Tom";
        text.text = Texts.MEETING_TOM;
    }
}
