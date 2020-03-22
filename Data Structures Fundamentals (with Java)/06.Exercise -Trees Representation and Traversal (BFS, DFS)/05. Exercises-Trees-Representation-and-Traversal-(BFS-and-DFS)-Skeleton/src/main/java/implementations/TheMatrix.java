package implementations;

public class TheMatrix {
    private char[][] matrix;
    private char fillChar;
    private char toBeReplaced;
    private int startRow;
    private int startCol;

    public TheMatrix(char[][] matrix, char fillChar, int startRow, int startCol) {
        this.matrix = matrix;
        this.fillChar = fillChar;
        this.startRow = startRow;
        this.startCol = startCol;
        this.toBeReplaced = this.matrix[this.startRow][this.startCol];
    }

    public void solve() {
        fillMatrix(this.startRow, this.startCol);
    }

    private void fillMatrix(int startRow, int startCol) {
        if (outOfRange(startRow, startCol) || this.matrix[startRow][startCol] != this.toBeReplaced) {
            return;
        }

        this.matrix[startRow][startCol] = this.fillChar;

        fillMatrix(startRow + 1, startCol);
        fillMatrix(startRow, startCol + 1);
        fillMatrix(startRow - 1, startCol);
        fillMatrix(startRow, startCol - 1);
    }

    private boolean outOfRange(int startRow, int startCol) {
        return startRow < 0 || startRow >= this.matrix.length
                || startCol < 0 || startCol >= this.matrix[startRow].length;
    }

    public String toOutputString() {
        StringBuilder sb = new StringBuilder();

        for (int row = 0; row < this.matrix.length; row++) {
            for (int col = 0; col < this.matrix[row].length; col++) {
                sb.append(matrix[row][col]);
            }
            sb.append(System.lineSeparator());
        }
        return sb.toString().trim();
    }
}
