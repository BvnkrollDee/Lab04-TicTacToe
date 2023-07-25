namespace TicTacToe_Lab04;

public class Player
{
    public string Name;
    public string Marker;

    public Player(string name, string marker)
    {
        Name = name;
        Marker = marker;
    }
}


class Program
{

    public static string[][] Board;
    static void Main(string[] args)
    {
        Console.WriteLine("This is Tic-Tac-Toe not TikTok");
        Console.Write("Player1's name: ");
        string player1Name = Console.ReadLine();
        Player player1 = new Player(player1Name, "X");
        Console.Write("Player2's name: ");
        string player2Name = Console.ReadLine();
        Player player2 = new Player(player2Name, "O");

        Console.WriteLine("====={0} vs {1}======", player1.Name, player2.Name);

        Board = new string[][] {
            new string[] {"1", "2", "3" },
            new string[] {"4", "5", "6" },
            new string[] {"7", "8", "9" }
        };
        Console.WriteLine("Here's the board ");
        displayBoard();

        Player currentPlayer = player1;
        string winner = null;
        while (winner == null)
        {
            Console.WriteLine("It's {0}'s turn", currentPlayer.Name);
            Console.WriteLine("Please choose a slot");
            displayBoard();
            string selectedSlot = Console.ReadLine();

            // Check if slot has already been selected
            bool isValid = SelectionIsValid(selectedSlot);

            if(isValid)
            {
                int[] indexes = SelectionToIndexes(selectedSlot);
                int row = indexes[0];
                int column = indexes[1];
                Board[row][column] = currentPlayer.Marker;
            }
            else {
                continue;
            }

            if(selectedSlot == "1")
            {
                string slotValue = Board[0][0];
                if (slotValue == "X" || slotValue == "O")
                {
                    Console.WriteLine("invalid selection");
                    continue;
                }
                Board[0][0] = currentPlayer.Marker;
            }
            else if (selectedSlot == "2")
            {
                Board[0][1] = currentPlayer.Marker;
            }
            else if (selectedSlot == "3")
            {
                Board[0][2] = currentPlayer.Marker;
            }
            else if (selectedSlot == "4")
            {
                Board[1][0] = currentPlayer.Marker;
            }
            else if (selectedSlot == "5")
            {
                Board[1][1] = currentPlayer.Marker;
            }
            else if (selectedSlot == "6")
            {
                Board[1][2] = currentPlayer.Marker;
            }
            else if (selectedSlot == "7")
            {
                Board[2][0] = currentPlayer.Marker;
            }
            else if (selectedSlot == "8")
            {
                Board[2][1] = currentPlayer.Marker;
            }
            else if (selectedSlot == "9")
            {
                Board[2][2] = currentPlayer.Marker;
            }

            if (currentPlayer == player1)
            {
                currentPlayer = player2;
            }else if ( currentPlayer == player2)
            {
                currentPlayer = player1;
            }
        }
    }

    static void displayBoard()
    {
        Console.WriteLine("|{0}||{1}||{2}|", Board[0][0], Board[0][1], Board[0][2]);
        Console.WriteLine("|{0}||{1}||{2}|", Board[1][0], Board[1][1], Board[1][2]);
        Console.WriteLine("|{0}||{1}||{2}|", Board[2][0], Board[2][1], Board[2][2]);
    }

    static int[] SelectionToIndexes(string selectedSlot)
    {
        int[] indexes = new int[2];
        switch(selectedSlot)
        {
            case "1":
                indexes[0] = 0;
                indexes[1] = 0;
                break;
            case "2":
                indexes[0] = 0;
                indexes[1] = 1;
                break;
            case "3":
                indexes[0] = 0;
                indexes[1] = 2;
                break;
            case "4":
                indexes[0] = 1;
                indexes[1] = 0;
                break;
            case "5":
                indexes[0] = 1;
                indexes[1] = 1;
                break;
            case "6":
                indexes[0] = 1;
                indexes[1] = 2;
                break;
            case "7":
                indexes[0] = 2;
                indexes[1] = 0;
                break;
            case "8":
                indexes[0] = 2;
                indexes[1] = 1;
                break;
            case "9":
                indexes[0] = 2;
                indexes[1] = 2;
                break;
        }
        return indexes;

    }

    static bool SelectionIsValid(string selectedSlot)
    {
        bool isValid = true;
        int[] indexes = SelectionToIndexes(selectedSlot);
        int row = indexes[0];
        int column = indexes[1];
        string slotValue = Board[row][column];
        if(selectedSlot == "1")
        {
             slotValue = Board[0][0];
            if(slotValue == "X" || slotValue == "O")
            {
                isValid = false;
            }
        }
        else if (selectedSlot == "2")
        {
            slotValue = Board[0][1];
            if (slotValue == "X" || slotValue == "O")
            {
                isValid = false;
            }
        }
        else if (selectedSlot == "3")
        {
            slotValue = Board[0][2];
            if (slotValue == "X" || slotValue == "O")
            {
                isValid = false;
            }
        }
        else if (selectedSlot == "4")
        {
            slotValue = Board[1][0];
            if (slotValue == "X" || slotValue == "O")
            {
                isValid = false;
            }
        }
        else if (selectedSlot == "5")
        {
            slotValue = Board[1][1];
            if (slotValue == "X" || slotValue == "O")
            {
                isValid = false;
            }
        }
        else if (selectedSlot == "6")
        {
            slotValue = Board[1][2];
            if (slotValue == "X" || slotValue == "O")
            {
                isValid = false;
            }
        }
        else if (selectedSlot == "7")
        {
            slotValue = Board[2][0];
            if (slotValue == "X" || slotValue == "O")
            {
                isValid = false;
            }
        }
        else if (selectedSlot == "8")
        {
            slotValue = Board[2][1];
            if (slotValue == "X" || slotValue == "O")
            {
                isValid = false;
            }
        }
        else if (selectedSlot == "9")
        {
            slotValue = Board[2][2];
            if (slotValue == "X" || slotValue == "O")
            {
                isValid = false;
            }
        }
        return isValid;
    }


}




