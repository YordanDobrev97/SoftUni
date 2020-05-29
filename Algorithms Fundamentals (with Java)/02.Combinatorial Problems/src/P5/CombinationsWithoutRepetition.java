package P5;
import java.util.Scanner;

public class CombinationsWithoutRepetition {
    private static String[] set;
    private static String[] combinations;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        set = scanner.nextLine().split("\\s+");
        int k = Integer.parseInt(scanner.nextLine());
        combinations = new String[k];

        printCombinationsWithoutRepetition(0, 0);
    }

    public static void printCombinationsWithoutRepetition(int index, int start) {
        if (index == combinations.length) {
            System.out.println(String.join(" ", combinations));
            return;
        }

        for (int i = start; i < set.length; i++) {
            combinations[index] = set[i];
            printCombinationsWithoutRepetition(index + 1, i + 1);
        }
    }
}