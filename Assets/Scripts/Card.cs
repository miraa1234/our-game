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

    private Transform _player;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        transform.LookAt(_player.transform.position + new Vector3(0, 1.375f, 0));
    }

    public void InitializeCard(CardInfo cardInfo, int amountInDeck)
    {
        _cardInfo = cardInfo;

        _amountText.text = amountInDeck.ToString();

        _nameText.text = cardInfo.GetCardName;
        _typeText.text = cardInfo.GetCardType.ToString();
        _descriptionText.text = cardInfo.GetCardDescription;
        _cardImage.sprite = cardInfo.GetCardImage;
    }
}
