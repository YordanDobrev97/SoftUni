package P6;
import java.util.Scanner;

public class CombinationsWithRepetition {
    private static String[] set;
    private static String[] combinations;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        set = scanner.nextLine().split("\\s+");
        int k = Integer.parseInt(scanner.nextLine());
        combinations = new String[k];

        printCombinationsWithRepetition(0, 0);
    }

    public static void printCombinationsWithRepetition(int index, int start) {
        if (index == combinations.length) {
            System.out.println(String.join(" ", combinations));
            return;
        }

        for (int i = start; i < set.length; i++) {
            combinations[index] = set[i];
            printCombinationsWithRepetition(index + 1, i);
        }
    }
}