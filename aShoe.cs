using System;

public class aShoe : IDrawCard
{
    Stack<aCard> shuffledDecks = new Stack<aCard>();
    aDeckOfCards[] decks;
    private int defaultSeed = 999;
    private int numOfCards, numOfDecks;
    private double buffer;//resuffle if numcards go below buffer
    Random singleRandom = null;

    public aShoe(int nod, int seed)
	{
		singleRandom = aRandomSingleton.getInstance(seed);
		numOfDecks = nod;
		shuffle();
	}

    public void shuffle()
    {
        decks = new aDeckOfCards[numOfDecks];
        for (int i = 0; i < numOfDecks; i++)
        {
            aDeckOfCards deck = new aDeckOfCards();
            decks[i] = deck;

        }

        numOfCards = numOfDecks * 52;
        buffer = numOfCards * .30;
        int random;
        bool[] cardPushed = new bool[numOfCards];
        for (int i = 0; i < numOfCards; i++)
        {
            random = singleRandom.Next() % numOfCards;
            while (cardPushed[random] != false)
            {
                random = singleRandom.Next() % numOfCards;
            }

            cardPushed[random] = true;
            shuffledDecks.Push(decks[random % numOfDecks].deck[random % 52]);
        }
    }

    public aCard Draw()
    {
        aCard card = shuffledDecks.Pop();
        numOfCards--;

        if (numOfCards < buffer)
        {
            shuffle();
        }

        return card;
    }
}
