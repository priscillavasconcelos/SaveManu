using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManuIsGoneScreen : Screen
{
    void Start()
    {
        title.text = Texts.MANUISGONE;
        text.text = Texts.MANUISGONE_TEXT;
        button.text = Texts.NEXT;
    }
}
