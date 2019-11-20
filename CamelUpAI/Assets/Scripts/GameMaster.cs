using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : ScriptableObject
{
    Dictionary<string, Camel> camelList = new Dictionary<string, Camel>(); //stores all the camels so it can call things like cameList["red"].position
    List<Player> playerList = new List<Player>(); //stores all players and their data (e.g. how many coins they have, what cards they have left, what tickets they have)
    List<TicketPile> ticketPiles = new List<TicketPile>(); //contains a list of all five ticket piles, each of which contain tickets
    //List<Die> diceList = new List<Die>(); //list that knows what dice have been rolled so far + all of the dice in the game
    //List<Tile> tileList = new List<Tile>(); //... need some sort of datatype here that knows what's up with the tiles?? idk if this is smart method
    CardPile winnerCards = new CardPile(); //stores cards played to winner bet pile. Cards are a defined object type with attributes (e.g. player, color)
    CardPile loserCards = new CardPile(); //similar to winnercards    
    int numRollsRemaining = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RollDice()
    {
        //Struple rollPair = gamePyramid.rollDie();
        //camelList[rollPair.nam].MoveCamel(rollPair.num);
        //numRollsRemaining--;
    }
}
