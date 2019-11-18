# CamelUp_Unity
```
* GAMEMASTER.cs IN SPECIFICS:
*   contains a list of players and their data (owned tickets, current money, card hand, whether tile has been played)
*   contains two lists for the two piles of played cards
*   contains five lists for the piles of tickets
*   stores list of dice rolled/not rolles
*   keeps track of how many die roll tiles are left
*   stores current location of all camels and played tiles
*   performs camel movement (?)
```

```
Scripts/GameMaster.cs
*   Scriptable object
*   manages the game
*   moves the camels, tracks player turns, etc.
```
```
Scripts/CamelScript.cs
*   moves camels
*   black/white camels inherit from this class
*   Gamemaster.cs calls "redCamel.Move(2)" to move red camel 2 spaces, for example
```
```
Scripts/PyramidScript.cs
*   rolls dice
*   performs roll animation
*   Gamemaster.cs calls "rollDie()" to roll a new die
*   Gamemaster.cs calls "returnDice()" to return all dice to the pyramid
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
