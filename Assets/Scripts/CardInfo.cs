using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Card", menuName = "ScriptableObjects/Card")] 
public class CardInfo : ScriptableObject
{
    [SerializeField] string _name;
    [SerializeField] Sprite _image;
    [SerializeField] GameObject _object;

}
