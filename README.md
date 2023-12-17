# The-Dungeon-of-OOP-Mastery


Kata: The Dungeon of OOP Mastery
Background:

You are tasked with creating a simple text-based dungeon crawler game where a player navigates through a series of rooms encountering various types of monsters and collecting treasures.
Objective:

Design a flexible system that allows for easy expansion and inclusion of new types of rooms, monsters, and player actions.
Core Requirements:

Encapsulation of Behaviors: Each type of monster should have its unique behavior encapsulated within its class.

Polymorphism and Inheritance: Design a class hierarchy for rooms and monsters that allows polymorphic interactions.

Player Actions: The player can perform actions like Attack, Defend, and UseItem. These should be methods in the Player class.

Strategy Pattern for Battle: Implement the strategy pattern for different battle strategies against different monster types.

Observer Pattern for Game State: Implement the observer pattern to allow the game state to update other parts of the application when changes occur (like a player entering a room or a monster being defeated).

Command Pattern for Player Commands: Implement the command pattern to encapsulate all player actions as objects.

Unit Testing: Write unit tests for the major functionalities.
Concrete strategies for IBattleStrategy
Concrete classes for different types of Rooms and Monsters

Kata Exercise:
------------------------
Monster and Room Design: Start by creating a variety of monsters and rooms. For example, a Troll might require the player to use a TrollBattleStrategy, while an Ogre could have a weakness that players can exploit with an OgreBattleStrategy.

Battle Strategy Implementation: For each monster, implement a battle strategy that the player can use to defeat it.

Player Encounters: Implement logic for what happens when a player enters a room. Each room might contain a monster, a puzzle, or treasure.

Expand the Game: Create a way to initialize a dungeon with a series of interconnected rooms and place monsters within them.

Player Inventory: Design an inventory system for the player that can hold items that affect battles, such as potions or weapons.

Game State Observer: Implement the observer pattern to have the game state broadcast events like OnPlayerEnterRoom and OnMonsterDefeated.

Player Commands: Utilize the command pattern to encapsulate player actions, which allows for features like undoing an action or queuing up a series of actions.

Unit Tests: Ensure your battle strategies, room encounters, and player actions are all working as intended with a suite of unit tests.

This kata is designed to be open-ended to allow for a lot of creativity and exploration in your OOP design. As you work through it, consider how you can apply SOLID principles to keep your code clean and maintainable.

