/*

You are given two strings, coordinate1 and coordinate2, representing the coordinates of a square on an 8 x 8 chessboard.

The coordinate will always represent a valid chessboard square. The coordinate will always have the letter first (indicating its column), and the number second (indicating its row).

Return true if these two squares have the same color and false otherwise.

*/

public class Solution {
    public bool CheckTwoChessboards(string coordinate1, string coordinate2) {
        int get_color_from_coord(string coordinate) {
            int column = (int)coordinate[0] - (int)'a';
            int row = (int)coordinate[1] - 1;
            return (column + row) % 2;
        }

        return get_color_from_coord(coordinate1) == get_color_from_coord(coordinate2);
    }
}
