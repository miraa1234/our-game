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

    public string GetCardName { get { return _cardName; } }
    public CardType GetCardType { get { return _cardType; } }
    public string GetCardDescription { get { return _cardDescription; } }
    public Sprite GetCardImage { get { return _cardImage; } }
    public GameObject GetCardObject { get { return _cardObject; } }
}
