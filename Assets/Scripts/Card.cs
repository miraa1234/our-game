using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    [SerializeField] private CardInfo _cardInfo;
    [SerializeField] private TMP_Text _nameText, _typeText, _descriptionText, _amountText;
    [SerializeField] private Image _cardImage;

    private void Start()
    {
        InitializeCard();
    }

    private void InitializeCard()
    {
        _nameText.text = _cardInfo.GetCardName;
        _typeText.text = _cardInfo.GetCardType.ToString();
        _descriptionText.text = _cardInfo.GetCardDescription;
        _cardImage.sprite = _cardInfo.GetCardImage;
    }
}
