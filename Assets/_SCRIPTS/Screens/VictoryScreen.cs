using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryScreen : Screen
{
    void Start()
    {
        title.text = Texts.VICTORY;
        subtitle.text = Texts.VICTORYSUBTITLE;
        text.text = Texts.VICTORY_TEXT;
        button.text = Texts.EXIT;
    }
}
