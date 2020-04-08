using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryScreen : Screen
{
    public Player player;
    void Start()
    {
        title.text = Texts.VICTORY;
        subtitle.text = Texts.VICTORYSUBTITLE;
        text.text = Texts.VICTORY_TEXT.Replace("XXX", player.playerName);
        button.text = Texts.EXIT;
    }
}
