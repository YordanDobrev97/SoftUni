package P2;

import java.util.HashSet;
import java.util.Scanner;

public class PermutationsWithRepetition {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] set =  scanner.nextLine().split("\\s+");

    }
    public static void printAllPermutations(int index, String[] set) {
        if (index == set.length) {
            System.out.println(String.join(" ", set));
            return;
        }

        printAllPermutations(index + 1, set);

        HashSet<String> swapped = new HashSet<>();
        swapped.add(set[index]);

        for (int i = index + 1; i < set.length; i++) {
            if (!swapped.contains(set[i])) {
                swap(set, index, i);
                printAllPermutations(index + 1, set);
                swap(set, index, i);
                swapped.add(set[i]);
            }
        }
    }

    private static void swap(String[] set, int firstIndex, int secondIndex) {
        String temp = set[firstIndex];
        set[firstIndex] = set[secondIndex];
        set[secondIndex] = temp;
    }
}
