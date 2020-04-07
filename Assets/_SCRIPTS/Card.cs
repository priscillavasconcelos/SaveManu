using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Cards")]
public class Card : ScriptableObject
{
    public Sprite cardSprite;
    [TextArea]
    public string description_pt;
    [TextArea]
    public string description_en;
}
