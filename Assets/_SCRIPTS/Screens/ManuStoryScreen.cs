using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManuStoryScreen : Screen
{
    void Start()
    {
        title.text = Texts.MEETMANU;
        text.text = Texts.MEETMANU_TEXT;
        button.text = Texts.NEXT;
    }
}
