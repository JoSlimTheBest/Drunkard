
using System.Collections.Generic;
using UnityEngine;

public class UsualDeck : MonoBehaviour
{    
    public List<GameObject> cardInCloseDeck = new List<GameObject>();


    private GameObject GiveRandomCard()
    {
        GameObject randomCard = cardInCloseDeck[Random.Range(0, cardInCloseDeck.Count)];
        cardInCloseDeck.Remove(randomCard);
        return randomCard;

    }


    private GameObject GiveFirstCard()
    {
        GameObject fp = cardInCloseDeck[0];
        cardInCloseDeck.Remove(fp);
        return fp;
    }

     
}
