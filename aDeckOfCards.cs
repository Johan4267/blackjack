using System;

public class aDeckOfCards
{
    public aCard[] deck;

    public aDeckOfCards()
    {
        deck = new aCard[52];
        for (int i = 0; i < 52; i++)
        {
            aCard card = new aCard(i);
            deck[i] = card;
        }
    }
}
