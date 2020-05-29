package P4;

import java.util.Scanner;

public class VariationsWithRepetitions {
    private static String[] set;
    private static String[] variations;
    private static boolean[] used;
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        set = scanner.nextLine().split("\\s+");
        int k = Integer.parseInt(scanner.nextLine());

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
            variations[index] = set[i];
            printVariationsWithoutRepetitions(index + 1);
        }
    }
}
