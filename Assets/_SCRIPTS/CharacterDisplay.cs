using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterDisplay : MonoBehaviour
{
    public Character character;
    public Text description;
    // Start is called before the first frame update
    void Start()
    {
        SetCharacter();
    }

    public void SetCharacter()
    {
        GetComponent<Image>().sprite = character.avatarSprite;
        GetComponentInChildren<Text>().text = character.characterName;
        if (description)
        {
            description.text = character.backStory;
        }
    }
}
