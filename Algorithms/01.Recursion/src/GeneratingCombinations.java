import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class GeneratingCombinations {
    public static void main(String[] args) throws IOException {
        BufferedReader console = new BufferedReader(
                new InputStreamReader(System.in));

        int[] numbers = Arrays.stream(console.readLine()
                .split("\\s+"))
                .mapToInt(Integer::parseInt)
                .toArray();


        int choose = Integer.parseInt(console.readLine());
        int[] vector = new int[choose];
        generatingCombinations(numbers, vector, 0, -1);
    }

    private static void generatingCombinations(int[] numbers, int[] vector, int index, int border) {
        if(index == vector.length){
            printVector(vector);
            return;
        }
        for(int i = border + 1; i < numbers.length; i++){
            vector[index] = numbers[i];
            generatingCombinations(numbers, vector, index + 1, i);
        }
    }

    private static void printVector(int[] vector) {
        for (int aVector : vector) {
            System.out.print(aVector + " ");
        }
        System.out.println();
    }
}
