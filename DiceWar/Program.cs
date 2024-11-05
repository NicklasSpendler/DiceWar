// See https://aka.ms/new-console-template for more information

using DiceWar;

Player player = new Player("Player");
Player computer = new Player("computer");

GameManager gameManager = new GameManager(player, computer);

gameManager.StartGame(3, 5);