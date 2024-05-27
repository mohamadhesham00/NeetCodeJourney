public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // Array for storing the values of rows
        bool[][] row = new bool[board.Length][];
        // Array for storing the values of columns
        bool[][] column = new bool[board.Length][];
        // Array for storing the values of subBoxes
        bool[][] subBox = new bool[board.Length][];

        // Initalize the the array to false to track it 
        for (int i = 0; i < board.Length; i++)
        {
            row[i] = new bool[board.Length];
            column[i] = new bool[board.Length];
            subBox[i] = new bool[board.Length];
        }
        int val = -1;
        // Iterate over the board
        for (int i = 0; i < board.Length; i++)
        {
            for(int j = 0; j < board[i].Length; j++)
            {
                // if it has a value from 1-9 otherwise we ignore it
                if(board[i][j] != '.')
                {
                    // turn the char to int and decrease 1 to store it in the right index
                    val = board[i][j] - '0' - 1;
                    // Get the current subGrid we are in right now
                    int currentSubBox = (i / 3) * 3 + (j / 3);
                    // if any of them are true this means there already the same number exists
                    if (row[i][val] || column[j][val] || subBox[currentSubBox][val] )
                        return false;
                    //Update it and make it true for tracking
                    row[i][val] = true;
                    column[j][val] = true;
                    subBox[currentSubBox][val] = true;
                    

                }
            }

        }
        // Means we found no duplicates in row , column or subBox so this means the sudoku is valid
        return true;
    }
}