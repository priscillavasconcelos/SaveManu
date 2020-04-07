using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card card;
    public Image image;
    public Text description;
    // Start is called before the first frame update
    void Start()
    {
        SetCharacter();
    }

    public void SetCharacter()
    {
        image.sprite = card.cardSprite;
        if (Texts.language == Texts.Language.Portuguese)
        {
            description.text = card.description_pt;
        }
        else
        {
            description.text = card.description_en;
        }
    }
}
