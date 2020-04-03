using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager manager { get; private set; }
    public GameObject playerTurnPrefab, canvas;
    public GameObject turnWarning;
    public GameObject changePlayerScreen;
    public GameObject victory, defeat, playerLost;

    public Character guilty;
    public List<TMP_Text> tips = new List<TMP_Text>();
    public List<Player> players = new List<Player>();
    public List<GameObject> playersTurn = new List<GameObject>();
    public List<Character> suspects = new List<Character>();
    public List<GameObject> gameScreens = new List<GameObject>();
    public int currentScreen;
    public int currentPlayer;
    private void Awake()
    {
        if (manager != null && manager != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            manager = this;
        }
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
                PlayerTurnScreen playerTurnScreen = screen.GetComponent<PlayerTurnScreen>();
                playerTurnScreen.player = players[x];
                playerTurnScreen.orderToPlay = x;
                playerTurnScreen.doNothingBtn.onClick.AddListener(() => NextTurn());
                for (int y = 0; y < guilty.tips.Count; y++)
                {
                    playerTurnScreen.tips[y].text = guilty.tips[y];
                }
                playersTurn.Add(screen);
                
                screen.SetActive(false);
            }
            
        }
        GameObject current = GetCurrentScreen();

        int index = gameScreens.IndexOf(current);
        currentScreen = index + 1;
        current.SetActive(false);
        gameScreens[currentScreen].SetActive(true);
        
    }

    public void StartGame()
    {
        currentPlayer = 0;

        GameObject current = GetCurrentScreen();
        int i = gameScreens.IndexOf(current);
        current.SetActive(false);

        playersTurn[currentPlayer].SetActive(true);
    }

    public void NextTurn()
    {
        GameObject current = GetCurrentScreen();

        int index = playersTurn.IndexOf(current);
        current.SetActive(false);

        if (index == playersTurn.Count-1)
        {
            currentPlayer = 0;
        }
        else
        {
            currentPlayer++;
        }
        playersTurn[currentPlayer].SetActive(true);

        if (currentPlayer > 0)
        {
            turnWarning.GetComponent<TurnWarningScreen>().SetPlayer(players[currentPlayer - 1]);
        }
        else
        {
            turnWarning.GetComponent<TurnWarningScreen>().SetPlayer(players[currentPlayer]);
        }
        
        turnWarning.SetActive(true);
        turnWarning.transform.SetAsLastSibling();
    }

    public void TipUnlocked()
    {
        GameObject current = GetCurrentScreen();

        int index = playersTurn.IndexOf(current);
        current.SetActive(false);
        currentPlayer++;
        playersTurn[currentPlayer].SetActive(true);

        GameObject clickedButton = EventSystem.current.currentSelectedGameObject;

        Button[] buttons = clickedButton.transform.parent.GetComponentsInChildren<Button>();

        foreach (Button button in buttons)
        {
            button.interactable = true;
        }
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

        foreach (GameObject playerTurn in playersTurn)
        {
            if (playerTurn.GetComponent<PlayerTurnScreen>())
            {
                for (int x = 0; x < playerTurn.GetComponent<PlayerTurnScreen>().tips.Count; x++)
                {
                    if (tip.GetComponent<TMP_Text>().text == playerTurn.GetComponent<PlayerTurnScreen>().tips[x].text)
                    {
                        playerTurn.GetComponent<PlayerTurnScreen>().tips[x].gameObject.SetActive(true);
                    }

                }
            }
            
            
        }

        clickedButton.SetActive(false);
        tip.SetActive(true);

    }

    public void PlayerWrongGuess(GameObject playerTurn, Player player)
    {
        playerLost.SetActive(true);
        playersTurn.Remove(playerTurn);
        players.Remove(player);
        Destroy(playerTurn);
        playerLost.transform.SetAsLastSibling();
    }
    public void DisableWrongPlayer()
    {
        if (players.Count < 2)
        {
            playerLost.SetActive(false);
            defeat.SetActive(true);
            defeat.transform.SetAsLastSibling();
        }
        else
        {
            NextTurn();
        }
    }

    public void TryAgain()
    {
        SceneManager.LoadScene("Teste");
    }

    public void TeamVictory(Player player)
    {
        string newText = victory.GetComponentInChildren<TMP_Text>().text.Replace("XXX", player.playerName);
        victory.GetComponentInChildren<TMP_Text>().text = newText;
        victory.SetActive(true);
        victory.transform.SetAsLastSibling();
    }
    public void TeamLoose()
    {
        
    }
}
