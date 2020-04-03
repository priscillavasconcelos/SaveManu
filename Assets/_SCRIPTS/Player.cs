using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public string playerName;
    public Sprite playerAvatarSprite;
    // Start is called before the first frame update
    void Start()
    {
        SetPlayer();
    }

    public void SetPlayer()
    {
        GetComponent<Image>().sprite = playerAvatarSprite;
        GetComponentInChildren<TMP_Text>().text = playerName;
    }
}
