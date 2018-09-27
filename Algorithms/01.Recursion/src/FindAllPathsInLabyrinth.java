import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class FindAllPathsInLabyrinth {
    static char[][] matrix;
    static boolean[][] visited;
    public static void main(String[] args) throws IOException {
        BufferedReader console = new BufferedReader(
                new InputStreamReader(System.in));

        int row = Integer.parseInt(console.readLine());
        int colum = Integer.parseInt(console.readLine());

        matrix = new char[row][colum];
        visited = new boolean[row][colum];

        for(int rows = 0; rows < row; rows++){
            String values = console.readLine();
            for(int col = 0; col < colum; col++){
                matrix[rows][col] = values.charAt(col);
            }
        }

       path(0, 0,"");
    }

    private static void path(int row, int col, String direction) {
        if(!isBounds(row,col)){
            return;
        }

        if(isExit(row,col)){
            System.out.println(direction);
        }else if(!isVisited(row,col) &&
                isFreePlace(row, col)){
            markAsVisited(row,col);
            path(row, col + 1, direction + "R");
            path(row + 1, col , direction + "D");
            path(row, col - 1, direction + "L");
            path(row - 1, col, direction + "U");
            unmarkVisited(row,col);
        }
    }

    private static void unmarkVisited(int row, int col) {
        visited[row][col] = false;
    }

    private static void markAsVisited(int row, int col) {
        visited[row][col] = true;
    }

    private static boolean isFreePlace(int row, int col) {
        return !(matrix[row][col] == '*');
    }

    private static boolean isVisited(int row, int col) {
        return visited[row][col];
    }

    private static boolean isExit(int row, int col) {
        return matrix[row][col] == 'e';
    }

    private static boolean isBounds(int row, int col) {
        return row <= matrix.length - 1
                && col <= matrix[0].length - 1
                && row >= 0
                && col >= 0;
    }
}
