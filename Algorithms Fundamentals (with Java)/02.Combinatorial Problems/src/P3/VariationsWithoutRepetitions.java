package P3;

import java.util.Scanner;

public class VariationsWithoutRepetitions {
    private static String[] set;
    private static String[] variations;
    private static boolean[] used;
    private static int k;
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        set = scanner.nextLine().split("\\s+");
        k = Integer.parseInt(scanner.nextLine());

        variations = new String[k];
        used = new boolean[set.length];

        printVariationsWithoutRepetitions(0);
    }

    public static void printVariationsWithoutRepetitions(int index) {
        if (index >= variations.length) {
            System.out.println(String.join(" ", variations));
            return;
        }

        for (int i = 0; i < set.length; i++) {
            if (!used[i]) {
                used[i] = true;
                variations[index] = set[i];
                printVariationsWithoutRepetitions(index + 1);
                used[i] = false;
            }
        }
    }
}