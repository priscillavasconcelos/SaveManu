using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class PlayerTurnScreen : Screen
{
    public Player player;
    public int orderToPlay;

    public TMP_Text playerName;
    public List<TMP_Text> tips = new List<TMP_Text>();
    public GameObject suspectsPanel;

    public Button doNothingBtn;

    private void Start()
    {
        playerName.text = player.playerName;
    }
    public void ToggleProfiles(bool activeProfile)
    {
        suspectsPanel.SetActive(activeProfile);
    }

    public void PointGuilty()
    {
        GameObject clickedButton = EventSystem.current.currentSelectedGameObject;
        GameObject clickedButtonParent = clickedButton.transform.parent.gameObject;
        
        CharacterDisplay current = clickedButtonParent.GetComponentInChildren<CharacterDisplay>();

        if (current.character == GameManager.manager.guilty)
        {
            GameManager.manager.TeamVictory(player);
        }
        else
        {
            GameManager.manager.PlayerWrongGuess(gameObject, player);
        }

    }
}
