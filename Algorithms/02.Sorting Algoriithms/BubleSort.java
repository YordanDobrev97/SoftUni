import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class BubleSort {
    public static void main(String[] args) throws IOException {
        BufferedReader console = new BufferedReader(new InputStreamReader(System.in));

        int[] arr = Arrays.stream(console.readLine()
                .split("\\s+"))
                .mapToInt(Integer::parseInt)
                .toArray();

        int[] sorted = bubleSort(arr);

        for (int aSorted : sorted) {
            System.out.println(aSorted);
        }
    }
    private static int[] bubleSort(int[] array){
        for(int i = 0; i < array.length; i++){
            for(int j = 0; j < array.length -1; j++){
                int currentElement = array[j];
                int nextElement = array[j + 1];

                if (currentElement > nextElement){
                    //swap
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
        return array;
    }
}
