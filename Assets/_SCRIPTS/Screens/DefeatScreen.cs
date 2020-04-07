using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefeatScreen : Screen
{
    void Start()
    {
        title.text = Texts.DEFEAT;
        subtitle.text = Texts.DEFEATSUBTITLE;
        text.text = Texts.DEFEAT_TEXT;
        button.text = Texts.EXIT;
    }
}
