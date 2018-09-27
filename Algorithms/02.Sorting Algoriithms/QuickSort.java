import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class QuickSort {
    public static void main(String[] args) throws IOException {
        BufferedReader console = new
                BufferedReader(new InputStreamReader(System.in));

        int[] arr = Arrays.stream(console.readLine()
                .split("\\s+"))
                .mapToInt(Integer::parseInt)
                .toArray();

        quickSort(arr, 0, arr.length - 1);

        for(int i = 0; i < arr.length; i++){
            System.out.println(arr[i]);
        }
    }
    private static void quickSort(int[]array, int low, int high){

        if(low < high){
            int pivot = partition(array, low, high);

            quickSort(array, low, high-1);
            quickSort(array, low + 1, high);
        }
    }
    private static int partition(int[] array, int left, int right){
        int pivot = array[right];

        int i = (left - 1);

        for(int j = left; j < right; j++){
            if(array[j] <= pivot){
                i++;
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        int temp = array[i + 1];
        array[i + 1] = array[right];
        array[right] = temp;

        return  i + 1;
    }

}
