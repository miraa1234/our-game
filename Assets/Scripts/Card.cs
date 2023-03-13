using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Card : MonoBehaviour
{
    [SerializeField] private CardInfo _cardInfo;
    [SerializeField] private TMP_Text _nameText, _typeText, _descriptionText, _amountText;
    [SerializeField] private SpriteRenderer _artSpriteRenderer;

    private void Start()
    {
        InitializeCard();
    }

    private void InitializeCard()
    {
        _nameText.text = _cardInfo.GetCardName;
        _typeText.text = _cardInfo.GetCardType.ToString();
        _descriptionText.text = _cardInfo.GetCardDescription;
        _artSpriteRenderer.sprite = _cardInfo.GetCardImage;
    }
}
