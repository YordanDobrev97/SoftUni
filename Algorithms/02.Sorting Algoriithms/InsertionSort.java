import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class InsertionSort {
    public static void main(String[] args) throws IOException {
        BufferedReader console = new
                BufferedReader(new InputStreamReader(System.in));

        int[] arr = Arrays.stream(console.readLine()
                .split("\\s+"))
                .mapToInt(Integer::parseInt)
                .toArray();

        int[] sorted = insertionSort(arr);

        for (int aSorted : sorted) {
            System.out.println(aSorted);
        }
    }
    private static int[] insertionSort(int[] array){
        for(int i = 0; i < array.length; i++){
            int currentElement = array[i];
            int prev = i - 1;

            while(prev >= 0 && array[prev] > currentElement){
                array[prev + 1] = array[prev];
                prev-=1;
            }
            array[prev + 1] = currentElement;
        }
        return array;
    }
}
