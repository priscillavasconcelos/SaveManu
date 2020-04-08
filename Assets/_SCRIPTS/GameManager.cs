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
    
    public GameObject playerPrefab, playersPanel;
    public GameObject playerTurnPrefab, canvas;
    public GameObject turnWarning;
    public GameObject changePlayerScreen;
    public GameObject victory, defeat, playerLost;

    public List<Sprite> playersAvatars = new List<Sprite>();

    public Character guilty;
    public List<Card> tips = new List<Card>();
    public List<Player> players = new List<Player>();
    public List<GameObject> playersTurn = new List<GameObject>();
    public List<Character> suspects = new List<Character>();
    public List<GameObject> gameScreens = new List<GameObject>();
    public int currentScreen;
    public int currentPlayer;
    public AudioSource cardSound, themeSong;
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

        if (PlayerPrefs.HasKey("Volume"))
        {
            Texts.toggleAudio = PlayerPrefs.GetInt("Volume", 0) == 0 ? false : true;
        }
        print(Texts.toggleAudio);
        AudioSource[] audios = GameObject.FindObjectsOfType<AudioSource>();
        foreach (AudioSource audio in audios)
        {
            audio.gameObject.SetActive(Texts.toggleAudio);
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

    public void AddPlayer()
    {
        if (playersPanel.transform.childCount < 4)
        {
            GameObject newPlayer = Instantiate(playerPrefab, playersPanel.transform);
            newPlayer.GetComponent<Player>().playerName = "Jogador";
            newPlayer.GetComponent<Player>().playerAvatarSprite = playersAvatars[Random.Range(0, playersAvatars.Count)];
        }
        
    }

    public void RemovePlayer()
    {

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

    public void PlaySoundCard()
    {
        cardSound.Play();
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
                playerTurnScreen.cardDisplay.GetComponent<Button>().onClick.AddListener(() => PlaySoundCard());
                for (int y = 0; y < guilty.tips.Count; y++)
                {
                    playerTurnScreen.tips[y] = guilty.tips[y];
                    //playerTurnScreen.tipsDisplay[y].card = guilty.tips[y];
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

    public void Back()
    {
        GameObject current = GetCurrentScreen();

        int index = gameScreens.IndexOf(current);
        currentScreen = index - 1;
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

        if (index == playersTurn.Count - 1)
        {
            currentPlayer = 0;
        }
        else
        {
            currentPlayer++;
        }
        playersTurn[currentPlayer].SetActive(true);

        turnWarning.GetComponent<TurnWarningScreen>().SetPlayer(players[currentPlayer]);

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
            tips[x] = suspects[sortedGuilty].tips[x];
        }
        return suspects[sortedGuilty];

    }

    public void PlayerWrongGuess(GameObject playerTurn, Player player)
    {
        themeSong.Stop();
        playerLost.SetActive(true);
        //playersTurn.Remove(playerTurn);
        //players.Remove(player);
        //Destroy(playerTurn);
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
        SceneManager.LoadScene("Game");
    }
    public void Exit()
    {
        //Application.Quit();
        SceneManager.LoadScene("Menu");
    }

    public void TeamVictory(Player player)
    {
        themeSong.Stop();
        //string newText = victory.GetComponentInChildren<Text>().text.Replace("XXX", player.playerName);
        //victory.GetComponentInChildren<Text>().text = newText;
        victory.GetComponent<VictoryScreen>().player = player;
        victory.SetActive(true);
        victory.transform.SetAsLastSibling();
    }
}
