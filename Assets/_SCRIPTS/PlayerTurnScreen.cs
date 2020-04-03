using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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

    //public void DoNothing()
    //{
    //    GameManager.manager.NextTurn();
    //}
}
