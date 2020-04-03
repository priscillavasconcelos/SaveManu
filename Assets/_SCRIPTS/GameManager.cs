using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager manager { get; private set; }
    public GameObject playerTurnPrefab, canvas;
    public GameObject turnWarning;
    public GameObject changePlayerScreen;
    private Character guilty;
    public List<TMP_Text> tips = new List<TMP_Text>();
    public List<Player> players = new List<Player>();
    public List<PlayerTurnScreen> playersTurn = new List<PlayerTurnScreen>();
    public List<Character> suspects = new List<Character>();
    public List<GameObject> gameScreens = new List<GameObject>();
    public int currentScreen;
    Player currentPlayer;

    private void Start()
    {
        
    }

    public void ChangePlayer()
    {
        GameObject clickedButton = EventSystem.current.currentSelectedGameObject;
        Player player = clickedButton.GetComponent<Player>();
        GameObject current = GetCurrentScreen();
        current.SetActive(false);
        changePlayerScreen.SetActive(true);
    }

    public void SavePlayerName(InputField inputField)
    {
        //inputField.text;

        changePlayerScreen.SetActive(false);
        gameScreens[0].SetActive(true);
    }

    public GameObject GetCurrentScreen()
    {
        GameObject clickedButton = EventSystem.current.currentSelectedGameObject;
        GameObject current = clickedButton.GetComponentInParent<Screen>().gameObject;
        return current;
    }

    public void Continue()
    {
        if (currentScreen == 0)
        {
            guilty = SortGuilty();
            players.AddRange(FindObjectsOfType<Player>());
            for (int x = 0; x < players.Count; x++)
            {
                GameObject screen = Instantiate(playerTurnPrefab, canvas.transform);
                gameScreens.Add(screen);

                screen.GetComponent<PlayerTurnScreen>().player = players[x];
                screen.GetComponent<PlayerTurnScreen>().orderToPlay = x;
                screen.GetComponent<PlayerTurnScreen>().doNothingBtn.onClick.AddListener(() => NextTurn(x));
                for (int y = 0; y < guilty.tips.Count; y++)
                {
                    screen.GetComponent<PlayerTurnScreen>().tips[y].text = guilty.tips[y];
                }
                playersTurn.Add(screen.GetComponent<PlayerTurnScreen>());
                
                screen.SetActive(false);
            }
            
        }
        GameObject current = GetCurrentScreen();

        int index = gameScreens.IndexOf(current);
        currentScreen = index + 1;
        current.SetActive(false);
        gameScreens[currentScreen].SetActive(true);
        
    }

    public void NextTurn(int index)
    {
        print(players[index - 1].name);
        Continue();
        turnWarning.GetComponent<TurnWarningScreen>().SetPlayer(players[index-1]);
        turnWarning.SetActive(true);
        turnWarning.transform.SetAsLastSibling();
    }

    public void RemoveWarning()
    {
        turnWarning.SetActive(false);
    }

    Character SortGuilty()
    {
        int sortedGuilty = Random.Range(0, suspects.Count);

        for (int x = 0; x < suspects[sortedGuilty].tips.Count; x++)
        {
            tips[x].text = suspects[sortedGuilty].tips[x];
        }
        return suspects[sortedGuilty];

    }

    public void DisplayTip(GameObject tip)
    {
        GameObject clickedButton = EventSystem.current.currentSelectedGameObject;

        Button[] buttons = clickedButton.transform.parent.GetComponentsInChildren<Button>();

        foreach (Button button in buttons)
        {
            button.interactable = false;
        }

        foreach (PlayerTurnScreen playerTurn in playersTurn)
        {
            for (int x = 0; x < playerTurn.tips.Count; x++)
            {
                if (tip.GetComponent<TMP_Text>().text == playerTurn.tips[x].text)
                {
                    playerTurn.tips[x].gameObject.SetActive(true);
                }
                
            }
            
        }

        clickedButton.SetActive(false);
        tip.SetActive(true);

    }

}
