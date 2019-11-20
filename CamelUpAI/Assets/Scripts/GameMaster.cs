using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : ScriptableObject
{
    public Dictionary<string, Camel> camelList = new Dictionary<string, Camel>();   //stores all the camels so it can call things like cameList["red"].position
    public Dictionary<string, Player> playerList = new Dictionary<string, Player>();//stores all players and their data (e.g. how many coins they have, what cards they have left, what tickets they have)
    public List<TicketPile> ticketPiles = new List<TicketPile>();                   //contains a list of all five ticket piles, each of which contain tickets
    //public List<Die> diceList;                                                    //list that knows what dice have been rolled so far + all of the dice in the game
    public CardPile winnerCards;                                                    //stores cards played to winner bet pile. Cards are a defined object type with attributes (e.g. player, color)
    public CardPile loserCards;                                                     //similar to winnercards    
    public TicketPile RollChips;
    //public Pyramid gamePyramid;
    //public Board gameBoard;

    // Start is called before the first frame update
    void Start()
    {
       //fill our Dictionary with camels and colors
       //fill our playerlist with the number of players in the game + their names
       //fill the ticket pile list with the five ticket piles
       //get the dice list from the pyramid
       //diceList = Pyramid.myDice;
       //assign the card piles
       //assign the roll chip pile
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RollDice()
    {
        //Struple rollPair = gamePyramid.rollDie();
        //camelList[rollPair.nam].MoveCamel(rollPair.num);
    }
}
