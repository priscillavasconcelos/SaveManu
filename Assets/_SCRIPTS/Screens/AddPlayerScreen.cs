using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerScreen : Screen
{
    void Start()
    {
        title.text = Texts.ADDPLAYER;
        text.text = Texts.ADDPLAYER_TEXT;
        button.text = Texts.NEXT;
    }
}
