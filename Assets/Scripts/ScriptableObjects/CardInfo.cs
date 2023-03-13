using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Card", menuName = "ScriptableObject/Card")]
public class CardInfo : ScriptableObject
{
    [SerializeField] string _cardName;
    [SerializeField] CardType _cardType;
    [SerializeField] string _cardDescription;
    [SerializeField] Sprite _cardImage;
    [SerializeField] GameObject _cardObject;
}
