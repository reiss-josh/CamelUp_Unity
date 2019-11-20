# CamelUp_Unity
```
Scripts/GameMaster.cs
*   Scriptable object
*   manages the game
*   contains a dictionary of camel objects
*   contains a dictionary of player objects
*	contains a list of pointers to Ticket Piles
*   contains a list of pointers to Die objects (acquired from Pyramid object)
*   contains two pointers to CardPile objects (which contain lists of betted cards)
*	contains a pointer to a TicketPile object -- the pile of five Roll chips
*	contains a pointer to a Pyramid object
*	contains a pointer to a GameBoard object
```
```
Scripts/Camel.cs
*   moves camels
*   black/white camels inherit from this class
*   Gamemaster.cs calls "redCamel.MoveCamel(2)" to move red camel 2 spaces, for example
*   keeps track of camel color, position, height, and what camel is below it
*   has void MoveCamel(int) method
```
```
Scripts/Board.cs
*	keeps track of where everything is (tiles, camels, etc)
*	holds a bunch of Vector3s [e.g. a Vector3 for each space on the track]
*	is "dumb"
```
```
Scripts/Card.cs
*   contains logic for cards
*   remembers original owner and color
```
```
Scripts/CardPile.cs
*   contains logic for piles of cards -- used for the winner/loser bets
*   keeps track of which pile it is, how many cards are in it, etc.
*	can have a card Added to it or can give itself back for scoring
```
```
Scripts/Player.cs
*   scripting for players
*   contains all relevant information for a single player
*   gets attached to Player prefab
*   has methods like ReturnTickets(), TakeTicket(), etc
```
```
Scripts/Pyramid.cs
*   rolls dice
*   performs roll animation
*   Gamemaster.cs calls "rollDie()" to roll a new die
*   Gamemaster.cs calls "returnDice()" to return all dice to the pyramid
*	contains a list of dice called diceList which knows where all the dice are
```
```
Scripts/Struple.cs
*   String Tuple!
*   C# doesn't support string tuples and i wanted a struct that just contains an int and a string
```
```
Scripts/Ticket.cs
*   Contains logic for tickets
*   remembers ticket value and ticket color
```
```
Scripts/TicketPile.cs
*   Stores ticket objects
*   remembers how many tickets are left, highest value ticket in the pile, and what color they are
```
.

.

.
```
Prefabs/GameBoard
*	its the game board.
```
```
Prefabs/BaseCamel
*   is prefab from which all camels are variants
```
```
Prefabs/Pyramid
*   ... pyramid
```
```
Prefabs/BaseDie
*   is prefab from which all dice are variants
```
```
Prefabs/BaseTicket
*   is prefab from which all tickets are variants
```
```
Prefabs/BaseCard
*   I think you get the point by now
```
```
Prefabs/BaseTile
```
```
Prefabs/SilverCoin
```
```
Prefabs/GoldCoin
```
```
Prefabs/GameBoard
```
