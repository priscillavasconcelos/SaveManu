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
        playerObj.GetComponentInChildren<Text>().text = player.playerName;
    }
}
