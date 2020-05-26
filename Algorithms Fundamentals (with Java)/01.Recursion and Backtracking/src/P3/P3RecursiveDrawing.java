package P3;
import java.util.Scanner;

public class P3RecursiveDrawing {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int sizeFigure = Integer.parseInt(scanner.nextLine());
        drawing(sizeFigure);
    }

    public static void drawing(int size) {
        if (size <= 0) {
            return;
        }
        System.out.println(newString(size, '*'));
        drawing(size - 1);
        System.out.println(newString(size, '#'));
    }

    public static String newString(int count, char symbol) {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < count; i++) {
            result.append(symbol);
        }
        return result.toString();
    }
}
