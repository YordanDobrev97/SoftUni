import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class SelectionSort {
    public static void main(String[] args) throws IOException {
        BufferedReader console = new
                BufferedReader(new InputStreamReader(System.in));

        int[] arr = Arrays.stream(console.readLine()
                .split("\\s+"))
                .mapToInt(Integer::parseInt)
                .toArray();

        int[] sortedArray = selectionSort(arr);

        for (int aSortedArray : sortedArray) {
            System.out.println(aSortedArray);
        }
    }
    private static int[] selectionSort(int[] array){

        for(int i =0; i < array.length; i++){
            int currentElement = array[i];

            int indexMinElement = 0;
            boolean isSwaped = false;
            for(int j = i + 1; j < array.length; j++){
                int nextElement = array[j];

                if(nextElement < currentElement){
                    indexMinElement = j;
                    isSwaped = true;
                }
            }
            if(isSwaped){
                int temp = array[i];
                array[i] = array[indexMinElement];
                array[indexMinElement] = temp;
            }

        }
        return array;
    }
}
