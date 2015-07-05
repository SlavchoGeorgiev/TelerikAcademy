namespace Minesweeper
{
    using System;
    using System.Collections.Generic;

    public class GameEngine
    {
        public static void Start()
        {
            const int MaxScore = 35;

            string userInput = string.Empty;
            char[,] userInterfaceBoard = Board.Generate();
            char[,] boardWithBombs = Board.GenerateWithMines();
            int scores = 0;
            bool gameOver = false;
            List<Player> topPlayersColection = new List<Player>(6);
            int row = 0;
            int col = 0;
            bool newGame = true;
            bool gameWined = false;

            do
            {
                if (newGame)
                {
                    Console.WriteLine("Let's play “Mines”. Try to find cells without mines." +
                    " Command 'top' shows top players, 'restart' start new game, 'exit' for exit the game!");
                    Board.Print(userInterfaceBoard);
                    newGame = false;
                }

                Console.Write("Plaese enter row and column : ");

                userInput = Console.ReadLine().Trim();

                if (userInput.Length >= 3)
                {
                    if (int.TryParse(userInput[0].ToString(), out row) &&
                    int.TryParse(userInput[2].ToString(), out col) &&
                        row <= userInterfaceBoard.GetLength(0) && col <= userInterfaceBoard.GetLength(1))
                    {
                        userInput = "turn";
                    }
                }

                switch (userInput)
                {
                    case "top":
                        Player.PrintColection(topPlayersColection);
                        break;
                    case "restart":
                        userInterfaceBoard = Board.Generate();
                        boardWithBombs = Board.GenerateWithMines();
                        Board.Print(userInterfaceBoard);
                        gameOver = false;
                        newGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bay bay!");
                        break;
                    case "turn":
                        if (boardWithBombs[row, col] != '*')
                        {
                            Board.AddResultToCellInBoards(userInterfaceBoard, boardWithBombs, row, col);
                            scores++;

                            if (MaxScore == scores)
                            {
                                gameWined = true;
                            }
                            else
                            {
                                Board.Print(userInterfaceBoard);
                            }
                        }
                        else
                        {
                            gameOver = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nInvalid input!\n");
                        break;
                }

                if (gameOver)
                {
                    Board.Print(boardWithBombs);
                    Console.Write("Game Over! Your result is: {0} scores. \nPlase enter your name: ", scores);
                    string userName = Console.ReadLine();
                    Player currentPlayer = new Player(userName, scores);

                    if (topPlayersColection.Count < 5)
                    {
                        topPlayersColection.Add(currentPlayer);
                    }
                    else
                    {
                        for (int i = 0; i < topPlayersColection.Count; i++)
                        {
                            if (topPlayersColection[i].Score < currentPlayer.Score)
                            {
                                topPlayersColection.Insert(i, currentPlayer);
                                topPlayersColection.RemoveAt(topPlayersColection.Count - 1);
                                break;
                            }
                        }
                    }

                    topPlayersColection.Sort((p1, p2) => p2.Name.CompareTo(p1.Name));
                    topPlayersColection.Sort((p1, p2) => p2.Score.CompareTo(p1.Score));
                    Player.PrintColection(topPlayersColection);

                    userInterfaceBoard = Board.Generate();
                    boardWithBombs = Board.GenerateWithMines();
                    scores = 0;
                    gameOver = false;
                    newGame = true;
                }

                if (gameWined)
                {
                    Console.WriteLine("\nYou win! You open {0} cels.", MaxScore);
                    Board.Print(boardWithBombs);
                    Console.WriteLine("Please enter your name: ");
                    string userName = Console.ReadLine();
                    Player currentPlayer = new Player(userName, scores);
                    topPlayersColection.Add(currentPlayer);
                    Player.PrintColection(topPlayersColection);

                    userInterfaceBoard = Board.Generate();
                    boardWithBombs = Board.GenerateWithMines();
                    scores = 0;
                    gameWined = false;
                    newGame = true;
                }
            }
            while (userInput != "exit");

            Console.WriteLine("Made in Bulgaria");
            Console.Read();
        }
    }
}
