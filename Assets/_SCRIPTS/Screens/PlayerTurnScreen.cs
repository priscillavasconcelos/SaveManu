using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class PlayerTurnScreen : Screen
{
    public Player player;
    public Image playerAvatar;
    public int orderToPlay;

    public Image timer;
    public List<Card> tips = new List<Card>();
    public List<CardDisplay> tipsDisplay = new List<CardDisplay>();
    public GameObject suspectsPanel;
    CharacterDisplay currentSuspect;
    public Button doNothingBtn;

    private void Start()
    {
        playerAvatar.sprite = player.playerAvatarSprite;
        title.text = Texts.TURNOF.Replace("XXX", player.playerName);
        //title.text = Texts.DEFEAT;
        subtitle.text = Texts.TURNOF_TEXT;
        //text.text = Texts.DEFEAT_TEXT;
        button.text = Texts.ACCUSE;
        doNothingBtn.GetComponentInChildren<Text>().text = Texts.NEXT;
        
    }
    private void OnEnable()
    {
        foreach (CardDisplay button in tipsDisplay)
        {
            if (!button.transform.GetChild(0).gameObject.activeSelf)
            {
                button.GetComponent<Button>().interactable = true;
            }

        }
    }
    private void OnDisable()
    {
        
    }
    public void ToggleProfiles(bool activeProfile)
    {
        suspectsPanel.SetActive(activeProfile);
    }

    public void SelectSuspect()
    {
        GameObject clickedButton = EventSystem.current.currentSelectedGameObject;
        GameObject selected = clickedButton.transform.Find("Image").gameObject;
        currentSuspect = clickedButton.GetComponent<CharacterDisplay>();
        foreach (CharacterDisplay cd in suspectsPanel.GetComponentsInChildren<CharacterDisplay>())
        {
            cd.transform.Find("Image").gameObject.SetActive(false);
        }

        selected.SetActive(true);
    }

    public void PointGuilty()
    {
        if (currentSuspect.character == GameManager.manager.guilty)
        {
            GameManager.manager.TeamVictory(player);
        }
        else
        {
            GameManager.manager.PlayerWrongGuess(gameObject, player);
        }
    }
    public void DisplayTip()
    {
        GameObject clickedButton = EventSystem.current.currentSelectedGameObject;

        Button[] buttons = clickedButton.transform.parent.GetComponentsInChildren<Button>();

        foreach (Button button in buttons)
        {
            button.interactable = false;
        }

        //clickedButton.SetActive(false);
        clickedButton.transform.GetChild(0).gameObject.SetActive(true);

    }
}
