using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnWarningScreen : Screen
{
    public GameObject playerObj;
    public Button next;

    public void SetPlayer(Player player)
    {
        playerObj.GetComponent<Image>().sprite = player.playerAvatarSprite;
        title.text = Texts.TURNOF.Replace("XXX", player.playerName);
        button.text = Texts.NEXT;
    }
}
