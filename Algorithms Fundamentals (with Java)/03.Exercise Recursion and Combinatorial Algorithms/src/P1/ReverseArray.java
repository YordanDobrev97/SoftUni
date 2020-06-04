package P1;
import java.util.Arrays;
import java.util.Scanner;

public class ReverseArray {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int[] numbers = Arrays.stream(scanner.nextLine()
                .split("\\s+"))
                .mapToInt(Integer::parseInt)
                .toArray();

        int[] reversedArray = new int[numbers.length];
        reverseArray(0, numbers.length - 1, numbers, reversedArray);
    }

    public static void reverseArray(int indexArray, int reversedArrayIndex,
                                    int[] array, int[] reversedArray) {
        if (indexArray >= array.length) {
            for (int value: reversedArray) {
                System.out.print(value + " ");
            }
            return;
        }
        reversedArray[reversedArrayIndex] = array[indexArray];
        reverseArray(indexArray + 1, reversedArrayIndex - 1, array, reversedArray);
    }
}
