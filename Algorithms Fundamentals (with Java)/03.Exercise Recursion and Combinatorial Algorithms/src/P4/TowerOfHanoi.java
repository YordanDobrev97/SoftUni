package P4;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayDeque;
import java.util.Comparator;
import java.util.stream.Collectors;

public class TowerOfHanoi {
    private static int step = 1;
    private static ArrayDeque<Integer> source = new ArrayDeque<>();
    private static ArrayDeque<Integer> middle = new ArrayDeque<>();
    private static ArrayDeque<Integer> destination = new ArrayDeque<>();

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int countDisks = Integer.parseInt(reader.readLine());

        for (int i = countDisks; i >= 1; i--) {
            source.push(i);
        }

        print();
        moveTower(countDisks, source, middle, destination);
    }

    public static void moveTower(int disk, ArrayDeque<Integer> source, ArrayDeque<Integer> middle,
                                 ArrayDeque<Integer> destination) {
        if (disk == 1) {
            int lastDisk = source.pop();
            destination.push(lastDisk);
            System.out.printf("Step #%d: Moved disk%n", step);
            print();
            step++;
        } else {
            moveTower(disk - 1, source, destination, middle);
            int currentDisk = source.pop();
            destination.push(currentDisk);

            System.out.printf("Step #%d: Moved disk%n", step);
            step++;
            print();
            moveTower(disk - 1, middle, source, destination);
        }
    }

    private static void print() {
        System.out.println(String.format("Source: %s%n" +
                "Destination: %s%n" +
                "Spare: %s%n", format(source), format(destination), format(middle)));
    }

    private static String format(ArrayDeque<Integer> stack) {
        return stack.stream()
                .sorted(Comparator.reverseOrder())
                .map(String::valueOf)
                .collect(Collectors.joining(", "));
    }
}
