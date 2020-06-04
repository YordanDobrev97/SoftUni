package P2;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Scanner;

public class NestedLoops {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int size = Integer.parseInt(reader.readLine());
        int[] values = new int[size];
        generateNLoops(0, values);
    }

    public static void generateNLoops(int index, int[] values) {
        if (index == values.length) {
            for (int value: values) {
                System.out.print(value + " ");
            }
            System.out.println();
            return;
        }

        for (int i = 1; i <= values.length; i++) {
            values[index] = i;
            generateNLoops(index + 1,values);
        }
    }
}
