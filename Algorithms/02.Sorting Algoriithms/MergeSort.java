import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class MergeSort {
    public static void main(String[] args) throws IOException {
        BufferedReader console = new
                BufferedReader(new InputStreamReader(System.in));

        int[] arr = Arrays.stream(console.readLine()
                .split("\\s+"))
                .mapToInt(Integer::parseInt)
                .toArray();

        mergeSort(arr, 0, arr.length - 1);

        for (int anArr : arr) {
            System.out.println(anArr);
        }
    }
    private static void mergeSort(int[] array, int left, int right){

        if(left < right) {
            int middle = (left + right) / 2;

            mergeSort(array, left, middle);
            mergeSort(array, middle + 1, right);

            merge(array, left, middle, right);
        }
    }
    private static void merge(int[] array, int left, int middle, int right){

        int firstSize = middle - left + 1;
        int secondSize = right - middle;

        int[] leftArr = new int[firstSize];
        int[] rightArr = new int[secondSize];

        //copy items in left array
        for(int i = 0; i < leftArr.length; i++){
            leftArr[i] = array[left + i];
        }

        //copy items in right array

        for(int i = 0; i < rightArr.length; i++){
            rightArr[i] = array[middle + 1 + i];
        }

        //merge left array and right array

        int index1 = 0;
        int index2 = 0;

        int k = left;
        while (index1 < firstSize && index2 < secondSize){
            if(leftArr[index1] <= rightArr[index2]){
                array[k] = leftArr[index1];
                index1++;
            }else{
                array[k] = rightArr[index2];
                index2++;
            }
            k++;
        }

        while (index1 < firstSize){
            array[k] = leftArr[index1];
            index1++;
            k++;
        }

        while (index2 < secondSize){
            array[k] = rightArr[index2];
            index2++;
            k++;
        }
    }
}