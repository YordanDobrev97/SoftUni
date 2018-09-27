import java.util.HashSet;
public class EightQueens {
    private int size = 8;
    private boolean[][] chessboard = new boolean[size][size];

    private HashSet<Integer> attackedRows = new HashSet<>();
    private HashSet<Integer> attackedColums = new HashSet<>();
    private HashSet<Integer> attackedLeftDiagonal = new HashSet<>();
    private HashSet<Integer> attackedRightDiagonal = new HashSet<>();

    public EightQueens(int size){
        printSolution(size);
    }

    public boolean[][] getChessboard(){
        return this.chessboard;
    }

    public void setChessboard(int rows, int colums){
        boolean[][] board = new boolean[rows][colums];
        this.chessboard = board;
    }

    public void printSolution(int row){
        if(row >= this.size){
            printQueens();
        }else {
            for (int i = 0; i < this.size; i++) {
                if (canPlaceQueen(row, i)) {
                    markAllPosition(row, i);
                    printSolution(row + 1);
                    unmarkAllPosition(row, i);
                }
            }
        }
    }

    private void printQueens() {
        StringBuilder sb = new StringBuilder();
        for(int row = 0; row < chessboard.length; row++){
            for(int col = 0; col < chessboard[row].length; col++){
                if(chessboard[row][col]){
                    sb.append("* ");
                }else{
                    sb.append("- ");
                }
            }
            sb.append("\n");
        }
        System.out.println(sb);
    }

    private void unmarkAllPosition(int size, int colum) {
        attackedRows.remove(size);
        attackedColums.remove(colum);
        attackedLeftDiagonal.remove(colum - size);
        attackedRightDiagonal.remove(size + colum);

        this.chessboard[size][colum] = false;
    }

    private void markAllPosition(int size, int colum) {
        attackedRows.add(size);
        attackedColums.add(colum);
        attackedLeftDiagonal.add(colum - size);
        attackedRightDiagonal.add(size + colum);

        this.chessboard[size][colum] = true;
    }

    private boolean canPlaceQueen(int size, int i) {
        boolean position =
                   attackedRows.contains(size)
                || attackedColums.contains(i)
                || attackedLeftDiagonal.contains(i - size)
                || attackedRightDiagonal.contains(size + i);

        return !position;
    }
}
