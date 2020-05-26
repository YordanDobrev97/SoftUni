package P5;

import java.util.ArrayList;
import java.util.Scanner;

public class PathsInLabyrinth {
    private static final char EXIT = 'e';
    private static final char WALL = '*';
    private static boolean[][] visited;

    private static ArrayList<String> path;
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int totalRow = Integer.parseInt(scanner.nextLine());
        int totalCol = Integer.parseInt(scanner.nextLine());
        char[][] matrix = new char[totalRow][totalCol];

        path = new ArrayList<>();
        visited = new boolean[totalRow][totalCol];

        for (int i = 0; i < totalRow; i++) {
            char[] values = scanner.nextLine().toCharArray();
            for (int j = 0; j < totalCol; j++) {
                matrix[i][j] = values[j];
            }
        }

        findPathInLabyrinth(matrix, 0, 0, "");
    }

    public static void findPathInLabyrinth(char[][] matrix, int row, int col, String direction) {
        if (!isRange(matrix, row, col) || matrix[row][col] == WALL || visited[row][col]) {
            return;
        }

        path.add(direction);

        if (matrix[row][col] == EXIT) {
            System.out.println(String.join("", path));
            path.remove(path.size() - 1);
            return;
        }

        visited[row][col] = true;
        findPathInLabyrinth(matrix, row, col + 1, "R"); // right
        findPathInLabyrinth(matrix, row + 1, col, "D"); // down
        findPathInLabyrinth(matrix, row, col - 1, "L"); // left
        findPathInLabyrinth(matrix, row - 1, col, "U"); // up
        visited[row][col] = false;
        path.remove(path.size() - 1);
    }

    private static boolean isRange(char[][] matrix, int row, int col) {
        return row >= 0 && row < matrix.length && col >= 0 && col < matrix[row].length;
    }
}