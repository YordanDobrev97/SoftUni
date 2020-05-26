package P6;
import java.util.HashSet;

public class Queens {
    private static final int ROWS = 8;
    private static final int COLS = 8;

    private static HashSet<Integer> attackedRows = new HashSet<>();
    private static HashSet<Integer> attackedCols = new HashSet<>();
    private static HashSet<Integer> attackedLeftDiagonals = new HashSet<>();
    private static HashSet<Integer> attackedRightDiagonals = new HashSet<>();

    private static boolean[][] board;
    public static void main(String[] args) {
        board = new boolean[ROWS][COLS];
        findPathQueens(0);
    }

    public static void findPathQueens(int row) {
        if (row == ROWS) {
            print();
            return;
        }

        for (int col = 0; col < ROWS; col++) {
            if (canPlaceQueen(row, col)) {
                mark(row, col);
                findPathQueens(row + 1);
                unmark(row, col);
            }
        }
    }

    private static void unmark(int row, int col) {
        attackedRows.remove(row);
        attackedCols.remove(col);
        attackedLeftDiagonals.remove(col - row);
        attackedRightDiagonals.remove(col + row);

        board[row][col] = false;
    }

    private static void mark(int row, int col) {
        attackedRows.add(row);
        attackedCols.add(col);
        attackedLeftDiagonals.add(col - row);
        attackedRightDiagonals.add(col + row);
        board[row][col] = true;
    }

    private static void print() {
        for (int row = 0; row < ROWS; row++) {
            for (int col = 0; col < COLS; col++) {
                System.out.print(board[row][col] ? '*' : '-');
                System.out.print(' ');
            }
            System.out.println();
        }
        System.out.println();
    }

    private static boolean canPlaceQueen(int row, int col) {
        boolean isRowAttacked = attackedRows.contains(row);
        boolean isColAttacked = attackedCols.contains(col);
        boolean isLeftAttacked = attackedLeftDiagonals.contains(col - row);
        boolean isRightAttacked = attackedRightDiagonals.contains(col + row);

        return !(isRowAttacked || isColAttacked || isLeftAttacked || isRightAttacked);
    }
}