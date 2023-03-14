using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckManager : MonoSingleton<DeckManager>
{
    public Dictionary<CardInfo, int> _deck = new Dictionary<CardInfo, int>();

    [SerializeField] private CardInfo _cardInfoTest;

    public void TriggerDebug()
    {
        AddCardToDeck(_cardInfoTest);

        foreach (KeyValuePair<CardInfo, int> kvp in _deck)
        Debug.Log($"Dictionary has {kvp.Value} of {kvp.Key}.");
    }

    public void AddCardToDeck(CardInfo cardToAdd)
    {
        if (_deck == null)
            return;

        if (_deck.ContainsKey(cardToAdd))
        {
            _deck[cardToAdd]++;
        }
        else
        {
            _deck.Add(cardToAdd, 1);
            Debug.Log($"{cardToAdd} added to Dictionary.");
        }
    }
}
