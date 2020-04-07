using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public string playerName;
    public Sprite playerAvatarSprite;
    public Image image;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        SetPlayer();
    }

    public void SetPlayer()
    {
        image.sprite = playerAvatarSprite;
        text.text = playerName;
    }
}
