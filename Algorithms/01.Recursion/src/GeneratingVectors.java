import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class GeneratingVectors {
    public static void main(String[] args) throws IOException {
        BufferedReader console = new BufferedReader(
                new InputStreamReader(System.in));

        int number = Integer.parseInt(console.readLine());
        int[] vector = new int[number];
        generatingVectors(vector, 0);
    }
    private static void generatingVectors(int[] vector, int index){
        if(index > vector.length - 1){
            printVector(vector);
            return;
        }

        for(int i = 0; i <=1; i++){
            vector[index] = i;
            generatingVectors(vector, index + 1);
        }
    }
    private static void printVector(int[] vector){
        for (int aVector : vector) {
            System.out.print(aVector);
        }
        System.out.println();
    }
}
