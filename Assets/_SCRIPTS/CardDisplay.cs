using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card card;
    public Text description;
    // Start is called before the first frame update
    void Start()
    {
        SetCharacter();
    }

    public void SetCharacter()
    {
        GetComponent<Image>().sprite = card.cardSprite;
        GetComponentInChildren<Text>().text = card.description;
    }
}
