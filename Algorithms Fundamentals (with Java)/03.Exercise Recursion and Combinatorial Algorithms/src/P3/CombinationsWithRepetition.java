package P3;

import java.util.Scanner;

public class CombinationsWithRepetition {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());
        int k = Integer.parseInt(scanner.nextLine());

        int[] values = new int[k];
        generateCombinations(0, 1, n, k, values);
    }

    public static void generateCombinations(int index, int start, int n, int k, int[] values) {
        if (index >= k) {
            for (int value: values) {
                System.out.print(value + " ");
            }
            System.out.println();
            return;
        }

        for (int i = start; i <= n; i++) {
            values[index] = i;
            generateCombinations(index + 1, i, n, k, values);
        }
    }
}
