package P4;
import java.util.Scanner;

public class P4Vectors {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());

        int[] vector = new int[n];
        generateVectors(vector, 0);
    }

    public static void generateVectors(int[] vector, int index) {
        if (index == vector.length) {
            print(vector);
            return;
        }

        for (int i = 0; i <= 1; i++) {
            vector[index] = i;
            generateVectors(vector, index + 1);
        }
    }

    private static void print(int[] vector) {
        for (int i = 0; i < vector.length; i++) {
            System.out.print(vector[i]);
        }
        System.out.println();
    }
}
