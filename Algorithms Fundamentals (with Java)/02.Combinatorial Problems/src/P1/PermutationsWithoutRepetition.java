package P1;
import java.util.Scanner;

public class PermutationsWithoutRepetition {
    private static boolean[] used;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] set =  scanner.nextLine().split("\\s+");
        used = new boolean[set.length];

        printAllPermutations(0, set);
    }

    public static void printAllPermutations(int index, String[] set, String[] resultSet) {
        if (index == set.length) {
            System.out.println(String.join(" ", resultSet));
            return;
        }

        for (int i = 0; i < set.length; i++) {
            if (!used[i]) {
                used[i] = true;
                resultSet[index] = set[i];
                printAllPermutations(index + 1, set, resultSet);
                used[i] = false;
            }
        }
    }

    public static void printAllPermutations(int index, String[] set) {
        if (index == set.length) {
            System.out.println(String.join(" ", set));
            return;
        }

        printAllPermutations(index + 1, set);

        for (int i = index + 1; i < set.length; i++) {
            swap(set, index, i);
            printAllPermutations(index + 1, set);
            swap(set, index, i);
        }
    }

    private static void swap(String[] set, int firstIndex, int secondIndex) {
        String temp = set[firstIndex];
        set[firstIndex] = set[secondIndex];
        set[secondIndex] = temp;
    }
}