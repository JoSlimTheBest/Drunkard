using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountCardInDeck : MonoBehaviour
{
    public GameObject takeCard;


    public void FixedUpdate()
    {
      GetComponent<TextMeshProUGUI>().text =  takeCard.GetComponent<UsualDeck>().cardInCloseDeck.Count.ToString();
    }
}
